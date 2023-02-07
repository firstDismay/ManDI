using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.command.common
{
    public class SignatureFunction : ISignatureFunction
    {
        IParametersFunction _function;
        public SignatureFunction(IParametersFunction function)
        {
            if (function == null) throw new ArgumentNullException("function");
            _function = function;
        }

        public string Signature
        {
            get
            {
                String function;
                StringBuilder signature = new StringBuilder();

                function = String.Format(@"SELECT * FROM {0}(?)", _function.NameFunction);
                if (_function.Parameters.Count() > 0)
                {
                    foreach (NpgsqlParameter p in _function.Parameters)
                    {
                        signature.Append(String.Format("@{0}, ", p.ParameterName));
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