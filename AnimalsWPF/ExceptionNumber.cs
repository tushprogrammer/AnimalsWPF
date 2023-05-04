using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsWPF
{
    class ExceptionNumber : Exception
    {
        public ExceptionNumber(string field, string message) : base(message)
        {            
            this.Field = field;
        }

        public string Field { get; set; }
    }
}
