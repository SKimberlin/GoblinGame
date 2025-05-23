using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public class Combatant : INotifyPropertyChanged
    {
        private string _name;
        private string _portraitPath;
        private double _maxHealth;
        private double _currentHealth;
        public event PropertyChangedEventHandler? PropertyChanged;

        public Combatant(string name, string portraitPath, double maxHealth, double currentHealth)
        {
            _name = name;
            _portraitPath = portraitPath;
            _maxHealth = maxHealth;
            _currentHealth = currentHealth;

        }
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public string Name { get { return _name; } set { _name = value; NotifyPropertyChanged(); } }
        public string PortraitPath { get { return _portraitPath; } set { _portraitPath = value; NotifyPropertyChanged(); } }
        public double MaxHealth { get { return _maxHealth; } set { _maxHealth = value; NotifyPropertyChanged(); } }
        public double CurrentHealth { get { return _currentHealth; } set { _currentHealth = value; NotifyPropertyChanged(); } }

    }
}
