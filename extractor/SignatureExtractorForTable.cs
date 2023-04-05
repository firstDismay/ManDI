using ManDI.command;
using Npgsql;
using System.Text;

namespace ManDI.extractor
{
    /// <summary>
    /// Экстрактор для извлечения сигнатуры вызова функции API из аргумента команды для класса DataTable
    /// </summary>
    public class SignatureExtractorForTable : ISignatureExtractor
    {
        public SignatureExtractorForTable() { }
        public string GetSignatureFunction(IParametersFunction function)
        {
            if (function == null) throw new ArgumentNullException("function");
            string signature;

            StringBuilder builder = new StringBuilder();

            signature = string.Format(@"SELECT * FROM {0}(?)", function.NameFunction);
            if (function.Parameters.Count() > 0)
            {
                foreach (NpgsqlParameter p in function.Parameters)
                {
                    builder.Append(string.Format("@{0}, ", p.ParameterName));
                }
                signature = signature.Replace("?", builder.ToString().Substring(0, builder.Length - 2));
            }
            else
            {
                signature = signature.Replace("?", "");
            }
            return signature;
        }
        public IEnumerable<NpgsqlParameter> GetParametersFunction(IParametersFunction function)
        {
            if (function == null) throw new ArgumentNullException("function");
            return function.Parameters;
        }
    }
}