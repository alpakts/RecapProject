using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ErrorResult:Result,IResult
    {
        public ErrorResult(bool success, string message) : base(false, message)
        {

        }
        public ErrorResult(bool success) : base(false)
        {

        }
    }
}
