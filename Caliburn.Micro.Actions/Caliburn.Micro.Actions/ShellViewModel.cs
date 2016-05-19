using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliburn.Micro.Actions
{
    public class ShellViewModel : PropertyChangedBase
    {
        private string _message;

        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                NotifyOfPropertyChange(() => Message);
                NotifyOfPropertyChange(() => CanChangeMessage);
                NotifyOfPropertyChange(() => CanChangeMessage2);
            }
        }

        

        private int _pressCount;


        public bool CanChangeMessage
        {
            get { return _pressCount < 10; }
        }

        public void ChangeMessage()
        {
            _pressCount++;

            Message = "Presses = " + _pressCount;
        }

        public bool CanChangeMessage2
        {
            get { return _pressCount < 20; }
        }

        public void ChangeMessage2(int incrementBy)
        {
            _pressCount += incrementBy;

            Message = "Presses = " + _pressCount;
        }

        public ShellViewModel()
        {
            Message = "Hello World";
        }
    }
}
