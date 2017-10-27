using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
  public abstract class NumericInputError: UserError
    {

        public override string UEMessage()
        {
           return "You tried to use a text input in a nemeric only field. This fired an error!";
        }
    }
}