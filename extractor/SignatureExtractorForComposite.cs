using ManDI.command;
using Npgsql;
using System.Text;

namespace ManDI.extractor
{
    /// <summary>
    /// Экстрактор для извлечения сигнатуры вызова функции API из аргумента команды для возврата сопоставленных композитных типов
    /// </summary>
    public class SignatureExtractorForComposite : ISignatureExtractor
    {
        IParametersFunction _function;
        public SignatureExtractorForComposite(IParametersFunction function)
        {
            if (function == null) throw new ArgumentNullException("function");
            _function = function;
        }

        public string Signature
        {
            get
            {
                string function;
                StringBuilder signature = new StringBuilder();

                function = string.Format(@"SELECT {0}(?)", _function.NameFunction);
                if (_function.Parameters.Count() > 0)
                {
                    foreach (NpgsqlParameter p in _function.Parameters)
                    {
                        signature.Append(string.Format("@{0}, ", p.ParameterName));
                    }
                    function = function.Replace("?", signature.ToString().Substring(0, signature.Length - 2));
                }
                else
                {
                    function = function.Replace("?", "");
                }
                return function;
            }
        }
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                return _function.Parameters;
            }
        }
    }
}