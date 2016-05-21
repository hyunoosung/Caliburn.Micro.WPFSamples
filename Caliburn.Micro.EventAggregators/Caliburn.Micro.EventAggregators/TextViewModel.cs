using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliburn.Micro.EventAggregators
{
    public class TextViewModel : PropertyChangedBase, IHandle<ChangeTextMessage>
    {

        private string _text;

        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;
                NotifyOfPropertyChange(() => Text);
            }
        }

        private IEventAggregator _events;

        public TextViewModel(IEventAggregator events)
        {
            _events = events;

            _events.Subscribe(this);

            Text = "No buttons pressed";
        }

        public void Handle(ChangeTextMessage message)
        {
            Text = message.Text; 
        }
    }
}
