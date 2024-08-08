using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiorParfum.Application.Extentions
{
    public class BiorParfumException : ApplicationException
    {
        public BiorParfumException(string message)
           : base($"Bior Parfum project exception: {message} ")
        {

        }
    }
}
