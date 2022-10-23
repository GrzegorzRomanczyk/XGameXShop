using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XGameXShop.ViewModels
{
    public class NewProductWindowViewModel
    {
        public IEnumerable<ConsoleEnum> ConsoleType { get; } = Enum.GetValues(typeof(ConsoleEnum)).Cast<ConsoleEnum>();
        public ConsoleEnum SelectedConsoleType { get; set; } = ConsoleEnum.None;

        public NewProductWindowViewModel()
        {

        }

    }
}
