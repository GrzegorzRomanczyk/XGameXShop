using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XGameXShop.Converters
{
    interface IConsoleTypConverter
    {
        string ConvertEnumToSting(ConsoleEnum consoleType);
    }
}
