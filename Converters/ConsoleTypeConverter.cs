using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XGameXShop.Converters
{
    public class ConsoleTypeConverter : IConsoleTypConverter
    {
        public string ConvertEnumToSting(ConsoleEnum consoleType)
        {
            string consoleName = string.Empty;
            switch (consoleType)
            {
                case ConsoleEnum.None:
                {
                   consoleName = string.Empty;
                   break;
                }
                default:
                {
                   consoleName = Enum.GetName(typeof(ConsoleEnum), (int)consoleType);
                   consoleName = consoleName.Replace("_", " ");
                   break;
                }
            }
            return consoleName;
        }
    }
}
