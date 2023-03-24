﻿using Npgsql;
using System.Text;

namespace ManDI.extractor
{
    /// <summary>
    /// Декоратор экстракторов сигнатур функций API для подставки условий выборки и сортировки
    /// </summary>
    public class SignatureFunctionDecoratorСondition : ISignatureExtractor
    {
        ISignatureExtractor _signature;
        UserContextSQL _user_context;

        public SignatureFunctionDecoratorСondition(ISignatureExtractor Signature, UserContextSQL UserContext)
        {
            if (Signature == null) throw new ArgumentNullException("Signature");
            if (UserContext == null) throw new ArgumentNullException("UserContext");
            _signature = Signature;
            _user_context = UserContext;
        }

        public string Signature
        {
            get
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append(_signature.Signature);
                if (_user_context.Where != null && !_signature.Signature.Contains("where", StringComparison.OrdinalIgnoreCase))
                {
                    stringBuilder.Append(" ");
                    stringBuilder.Append(_user_context.Where);
                }
                if (_user_context.Limit != null && !_signature.Signature.Contains("limit", StringComparison.OrdinalIgnoreCase))
                {
                    stringBuilder.Append(" ");
                    stringBuilder.Append(_user_context.Limit);
                }

                if (_user_context.OrderBy != null && !_signature.Signature.Contains("order by", StringComparison.OrdinalIgnoreCase))
                {
                    stringBuilder.Append(" ");
                    stringBuilder.Append(_user_context.OrderBy);
                }
                return stringBuilder.ToString();
            }
        }
        public IEnumerable<NpgsqlParameter> Parameters
        {
            get
            {
                return _signature.Parameters;
            }
        }
    }
}