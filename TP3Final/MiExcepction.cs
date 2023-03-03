using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3Final
{
    [Serializable]
    internal class MiException : ApplicationException
    {
        public MiException() : base("Error") { }
        public MiException(string m) : base(m) { }
        public MiException(string m, Exception iEx) : base(m, iEx) { }
    }
}
