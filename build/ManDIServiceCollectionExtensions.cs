using ManDI;
using ManDI.build;
using ManDI.enums;
using ManDI.executor;
using ManDI.extractor;
using Npgsql;
using Microsoft.Extensions.DependencyInjection;

namespace WebClient.build
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
            if (options != null)
            {
                switch (options.SignatureExtractorMode)
                {
                    case eSignatureExtractorMode.SignatureExtractorForComposite:
                        services.Add(new ServiceDescriptor(typeof(ISignatureExtractor), typeof(SignatureExtractorForComposite), ServiceLifetime.Scoped));
                        break;
                    case eSignatureExtractorMode.SignatureExtractorForTable:
                        services.Add(new ServiceDescriptor(typeof(ISignatureExtractor), typeof(SignatureExtractorForTable), ServiceLifetime.Scoped));
                        break;
                }
            }
            else
            {
                services.Add(new ServiceDescriptor(typeof(ISignatureExtractor), typeof(SignatureExtractorForComposite), ServiceLifetime.Scoped));
            }
            services.Add(new ServiceDescriptor(typeof(ICommandExecutor), typeof(command_executor), ServiceLifetime.Scoped));

            return services;
        }
    }
}
