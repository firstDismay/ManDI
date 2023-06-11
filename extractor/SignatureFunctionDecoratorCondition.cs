using ManDI.command;
using Npgsql;
using System.Text;

namespace ManDI.extractor
{
    /// <summary>
    /// Декоратор экстракторов сигнатур функций API для подставки условий выборки и сортировки
    /// </summary>
    public class SignatureFunctionDecoratorCondition : ISignatureExtractor
    {
        ISignatureExtractor signature;
        UserContextSQL user_context;

        public SignatureFunctionDecoratorCondition(ISignatureExtractor Signature, UserContextSQL UserContext)
        {
            if (Signature == null) throw new ArgumentNullException("Signature");
            if (UserContext == null) throw new ArgumentNullException("UserContext");
            this.signature = Signature;
            this.user_context = UserContext;
        }

        public string GetSignatureFunction(IParametersFunction function)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(this.signature.GetSignatureFunction(function));
            if (this.user_context.Where != null && !stringBuilder.ToString().Contains("where", StringComparison.OrdinalIgnoreCase))
            {
                stringBuilder.Append(" ");
                stringBuilder.Append(this.user_context.Where);
            }
            if (this.user_context.Limit != null && !stringBuilder.ToString().Contains("limit", StringComparison.OrdinalIgnoreCase))
            {
                stringBuilder.Append(" ");
                stringBuilder.Append(this.user_context.Limit);
            }

            if (this.user_context.OrderBy != null && !stringBuilder.ToString().Contains("order by", StringComparison.OrdinalIgnoreCase))
            {
                stringBuilder.Append(" ");
                stringBuilder.Append(this.user_context.OrderBy);
            }
            return stringBuilder.ToString();
        }
        public IEnumerable<NpgsqlParameter> GetParametersFunction(IParametersFunction function)
        {
            return function.Parameters;
        }
    }
}