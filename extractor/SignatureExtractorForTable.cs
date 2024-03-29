﻿using ManDI.command;
using Npgsql;
using System.Text;

namespace ManDI.extractor
{
    /// <summary>
    /// Экстрактор для извлечения сигнатуры вызова функции API из аргумента команды для класса DataTable
    /// </summary>
    public class SignatureExtractorForTable : ISignatureExtractor
    {
        string signature;
        IParametersFunction function;
        public SignatureExtractorForTable() { }
        public string GetSignatureFunction(IParametersFunction Function)
        {
            if (Function == null) throw new ArgumentNullException("function");
            this.function = Function;

            StringBuilder builder = new StringBuilder();

            signature = string.Format(@"SELECT entity.* FROM {0}(?) entity ", function.NameFunction);
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

            if (this.function.Condition != null || this.function.Condition != "")
            {
                builder = new StringBuilder(signature);
                builder.Append(" ");
                builder.Append(this.function.Condition);
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