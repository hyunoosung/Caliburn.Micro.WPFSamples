using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliburn.Micro.EventAggregators
{
    public class ButtonsViewModel
    {
        private IEventAggregator _events;

        public ButtonsViewModel(IEventAggregator events)
        {
            _events = events;
        }

        public void Button1()
        {
            _events.PublishOnUIThread(new ChangeTextMessage("Button 1 Pressed"));
        }

        public void Button2()
        {
            _events.PublishOnUIThread(new ChangeTextMessage("Button 2 Pressed"));
        }

        public void Button3()
        {
            _events.PublishOnUIThread(new ChangeTextMessage("Button 3 Pressed"));
        }
    }
}
