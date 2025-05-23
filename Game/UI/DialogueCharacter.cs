using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GoblinMode.UI
{
    public class DialogueCharacter : INotifyPropertyChanged
    {
        private string _name;
        private Image _portrait;
        public event PropertyChangedEventHandler? PropertyChanged;

        public string Name { get { return _name; } set { _name = value; NotifyPropertyChanged(); } }
        public Image Portrait { get { return _portrait; } set { _portrait = value; NotifyPropertyChanged(); } }
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
