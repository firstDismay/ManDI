using ManDI.build;
using ManDI.command;
using ManDI.extractor;
using Microsoft.Extensions.Logging;
using Npgsql;
using System.Data;
using System.Text;

namespace ManDI.executor
{
    /// <summary>
    /// Класс декоратор для логирования выполнения команд исполнителем
    /// </summary>
    public class command_executor_decorator_logger : ICommandExecutor
    {
        private readonly ICommandExecutor command_executor;
        private readonly ILoggerFactory logger_factory;
        private readonly ILogger logger;
        public command_executor_decorator_logger(ICommandExecutor CommandExecutor, ILoggerFactory LoggerFactory)
        {
            if (CommandExecutor == null) throw new ArgumentNullException("CommandExecutor");
            this.command_executor = CommandExecutor;

            if (LoggerFactory == null) throw new ArgumentNullException("LoggerFactory");
            this.logger_factory = LoggerFactory;

            this.logger = LoggerFactory.CreateLogger<command_executor>();
        }
        public int ExecuteNonQuery(IParametersFunction function)
        {
            int result;
            DateTime TimeStart = DateTime.Now;
            DateTime TimeEnd;
            try
            {
                result = this.command_executor.ExecuteNonQuery(function);
                TimeEnd = DateTime.Now;
                this.logger.LogInformation(Response(function, TimeStart, TimeEnd), function.Parameters);
            }
            catch (Exception ex) 
            {
                TimeEnd = DateTime.Now;
                this.logger.LogError(Response(function, TimeStart, TimeEnd), function.Parameters);
                throw;
            }
            return result;
        }
        public object ExecuteScalar(IParametersFunction function)
        {
            object result;
            DateTime TimeStart = DateTime.Now;
            DateTime TimeEnd;
            try
            {
                result = this.command_executor.ExecuteScalar(function);
                TimeEnd = DateTime.Now;
                this.logger.LogInformation(Response(function, TimeStart, TimeEnd), function.Parameters);
            }
            catch (Exception ex)
            {
                TimeEnd = DateTime.Now;
                this.logger.LogError(Response(function, TimeStart, TimeEnd), function.Parameters);
                throw;
            }
            return result;
        }

        public DataTable Fill(IParametersFunction function)
        {
            DataTable result = new DataTable();
            DateTime TimeStart = DateTime.Now;
            DateTime TimeEnd;
            try
            {
                result = this.command_executor.Fill(function);
                TimeEnd = DateTime.Now;
                this.logger.LogInformation(Response(function, TimeStart, TimeEnd), function.Parameters);
            }
            catch (Exception ex)
            {
                TimeEnd = DateTime.Now;
                this.logger.LogError(Response(function, TimeStart, TimeEnd), function.Parameters);
                throw;
            }
            return result;
        }

        private String Response(IParametersFunction function, DateTime TimeStart, DateTime TimeEnd)
        { 
            StringBuilder result = new StringBuilder();
            result.Append(String.Format("Выполнение: {0}(", function.NameFunction));

            foreach (var parametr in function.Parameters)
            {
                result.Append(String.Format("{0}={1}", parametr.ParameterName, parametr.Value.ToString()));
            }
            
            result.Append(String.Format(") Длительность: {0}мс", (TimeEnd - TimeStart).TotalMilliseconds));

            return result.ToString();
        }
    }
}