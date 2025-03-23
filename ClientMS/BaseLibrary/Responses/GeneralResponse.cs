using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLibrary.Responses
{
    public class GeneralResponse(bool Flag, string Message = null!)
    {
        public bool Flag { get; } = Flag;
        public string Message { get; } = Message;
    }
}
