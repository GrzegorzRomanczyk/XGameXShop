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
        public IEnumerable<PEGIEnum> PEGIType { get; } = Enum.GetValues(typeof(PEGIEnum)).Cast<PEGIEnum>();
        public PEGIEnum SelectedPEGIType { get; set; } = PEGIEnum.None;
        public ConsoleEnum SelectedConsoleType { get; set; } = ConsoleEnum.None;

        public NewProductWindowViewModel()
        {

        }

    }
}
