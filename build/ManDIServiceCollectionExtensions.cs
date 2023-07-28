using ManDI;
using ManDI.build;
using ManDI.enums;
using ManDI.executor;
using ManDI.extractor;
using Npgsql;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ManDI.build
{
    /// <summary>
    /// Сборка сервисов доступа к данным
    /// </summary>
    public static class ManDIServiceCollectionExtensions
    {
        public static IServiceCollection AddManDI(this IServiceCollection services, ManDiOptions options,
            params Action<IServiceCollection>[]? configureServicesCallbacks)
        {
            services.AddSingleton<NpgsqlConnectionStringBuilder>(new NpgsqlConnectionStringBuilder(options.ConnectionStrings));
            services.AddScoped<IDataService, ManDiDataService>();

            if (configureServicesCallbacks != null)
            {
                foreach (var callback in configureServicesCallbacks)
                {
                    callback(services);
                }
            }

            if (!services.Any(x => x.ServiceType == typeof(ISignatureExtractor)))
            {
                services.AddScoped<ISignatureExtractor, SignatureExtractorForComposite>();
            }
            
            if (!services.Any(x => x.ServiceType == typeof(ICommandExecutor)))
            {
                services.AddScoped<ICommandExecutor, command_executor>();
            }

            if (!services.Any(x => x.ServiceType == typeof(IExportExecutor)))
            {
                services.AddScoped<IExportExecutor, export_executor>();
            }

            if (services.Any(x => x.ServiceType == typeof(ILoggerFactory)))
            {
                services.Decorate<ICommandExecutor, command_executor_decorator_logger>();
            }
            return services;
        }
    }
}
