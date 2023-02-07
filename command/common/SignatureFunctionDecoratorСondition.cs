using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManDI.command.common
{
    public class SignatureFunctionDecoratorСondition : ISignatureFunction
    {
        ISignatureFunction _signature;
        UserContextSQL _user_context;
        
        public SignatureFunctionDecoratorСondition(ISignatureFunction Signature, UserContextSQL UserContext)
        {
            if (Signature == null) throw new ArgumentNullException("Signature");
            if(UserContext == null) throw new ArgumentNullException("UserContext");
            _signature = Signature;
            _user_context= UserContext;
        }

        public String Signature
        {
            get
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append(_signature.Signature);
                if ((_user_context.Where != null) && !(_signature.Signature.Contains("where",  StringComparison.OrdinalIgnoreCase)) )
                {
                    stringBuilder.Append(" ");
                    stringBuilder.Append(_user_context.Where);
                }
                if ((_user_context.Limit != null) && !(_signature.Signature.Contains("limit", StringComparison.OrdinalIgnoreCase)))
                {
                    stringBuilder.Append(" ");
                    stringBuilder.Append(_user_context.Limit);
                }

                if ((_user_context.OrderBy != null) && !(_signature.Signature.Contains("order by", StringComparison.OrdinalIgnoreCase)))
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