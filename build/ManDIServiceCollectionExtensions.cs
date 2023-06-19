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
        public static IServiceCollection AddManDI(this IServiceCollection services, ManDiOptions options)
        {
            NpgsqlConnectionStringBuilder csb = new NpgsqlConnectionStringBuilder(options.ConnectionStrings);

            services.Add(new ServiceDescriptor(typeof(NpgsqlConnectionStringBuilder), csb));
            services.Add(new ServiceDescriptor(typeof(IDataService), typeof(ManDiDataService), ServiceLifetime.Scoped));
            
                switch (options.SignatureExtractorMode)
                {
                    case eSignatureExtractorMode.SignatureExtractorForComposite:
                        services.Add(new ServiceDescriptor(typeof(ISignatureExtractor), typeof(SignatureExtractorForComposite), ServiceLifetime.Scoped));
                        break;
                    case eSignatureExtractorMode.SignatureExtractorForTable:
                        services.Add(new ServiceDescriptor(typeof(ISignatureExtractor), typeof(SignatureExtractorForTable), ServiceLifetime.Scoped));
                        break;
                }
            services.AddScoped<ICommandExecutor, command_executor>();
            if (options.Logger!= null)
            {
                services.AddSingleton<ILogger>(options.Logger);
                services.Decorate<ICommandExecutor, command_executor_decorator_logger>();
            }
            return services;
        }
    }
}
