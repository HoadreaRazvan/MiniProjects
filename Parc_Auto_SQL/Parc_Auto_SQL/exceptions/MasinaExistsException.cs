using System;
using System.Collections.Generic;
using System.Text;

namespace App.exceptions
{
    public class MasinaExistsException:Exception
    {
        public MasinaExistsException(string message) : base(message)
        {
        }
    }
}
