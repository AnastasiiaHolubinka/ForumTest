using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumTestBLL.Infrastructure
{
    public class ValidationException : ApplicationException
    {
        public ValidationException() : base() { }
        public ValidationException(string str, string property) : base(str)
        {
            Property = property;
        }

        public string Property { get; protected set; }

        public override string ToString()
        {
            return Message;
        }
    }
}
