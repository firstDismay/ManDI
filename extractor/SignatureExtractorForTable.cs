using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using ManDI.command;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.extractor
{
    /// <summary>
    /// Экстрактор для извлечения сигнатуры вызова функции API из аргумента команды для класса DataTable
    /// </summary>
    public class SignatureExtractorForTable : ISignatureExtractor
    {
        IParametersFunction _function;
        public SignatureExtractorForTable(IParametersFunction function)
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

                function = string.Format(@"SELECT * FROM {0}(?)", _function.NameFunction);
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