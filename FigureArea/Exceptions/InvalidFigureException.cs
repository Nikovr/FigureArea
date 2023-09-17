using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea.Exceptions
{
    public class InvalidFigureException : FigureException
    {
        public InvalidFigureException(string? message) : base("can not create figure - " + message)
        {
        }
    }
}
