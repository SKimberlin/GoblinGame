using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public class DialogueCharacter : INotifyPropertyChanged
    {
        private string _name;
        private string _portraitPath;
        public event PropertyChangedEventHandler? PropertyChanged;

        public string Name { get { return _name; } set { _name = value; NotifyPropertyChanged(); } }
        public string PortraitPath { get { return _portraitPath; } set { _portraitPath = value; NotifyPropertyChanged(); } }
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
