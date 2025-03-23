using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLibrary.Responses
{
    public class LoginResponse(bool Flag, string Message = null!, string Token = null!, string RefreshToken = null!)
    {
        public bool Flag { get; } = Flag;
        public string Message { get; } = Message;
        public string Token { get; } = Token;
        public string RefreshToken { get; } = RefreshToken;
    }
}
