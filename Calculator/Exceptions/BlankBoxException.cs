﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.Exceptions
{
    public class BlankBoxException:Exception
    {
        public BlankBoxException(string message):base( message)
        {
            
        }
    }
}
