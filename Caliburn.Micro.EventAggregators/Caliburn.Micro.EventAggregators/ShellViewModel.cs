using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliburn.Micro.EventAggregators
{
    public class ShellViewModel : PropertyChangedBase
    {
        public ButtonsViewModel ButtonsVM
        {
            get;
            set;
        }

        public TextViewModel TextVM
        {
            get;
            set;
        }

        public ShellViewModel()
        {
            IEventAggregator events = new EventAggregator();

            ButtonsVM = new ButtonsViewModel(events);
            TextVM = new TextViewModel(events);
        }
    }
}
