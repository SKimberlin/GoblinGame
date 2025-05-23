using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GoblinMode.UI
{
    public class Combatant : INotifyPropertyChanged
    {
        private string _name;
        private Image _portrait;
        private double _maxHealth;
        private double _currentHealth;
        public event PropertyChangedEventHandler? PropertyChanged;

        public Combatant(string name, Image portrait, double maxHealth, double currentHealth)
        {
            _name = name;
            _portrait = portrait;
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
        public Image Portrait { get { return _portrait; } set { _portrait = value; NotifyPropertyChanged(); } }
        public double MaxHealth { get { return _maxHealth; } set { _maxHealth = value; NotifyPropertyChanged(); } }
        public double CurrentHealth { get { return _currentHealth; } set { _currentHealth = value; NotifyPropertyChanged(); } }

    }
}
