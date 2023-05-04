using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsWPF
{
    class ExceptionNumber : Exception
    {
        public ExceptionNumber(string message, string field) : base(message)
        {            
            this.Field = field;
        }

        public string Field { get; set; }
    }
}
