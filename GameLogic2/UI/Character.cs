using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public class Character : INotifyPropertyChanged
    {
        private string _name;
        private int _power;   
        private int _sneak;   
        private int _grit;    
        private int _mischief;
        private int _cunning; 
        private int _skitter; 
        private int _gleam;
        private int _points;
        private int _maxPoints;
        public event PropertyChangedEventHandler? PropertyChanged;

        public Character() 
        {
            _name = "";
            _power = 0;
            _sneak = 0;
            _grit = 0;
            _mischief = 0;
            _cunning = 0;
            _skitter = 0;
            _gleam = 0;
            _maxPoints = 35;
            _points = _maxPoints;
        }

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public string Name { get { return _name; } set { _name = value; NotifyPropertyChanged(); } }
        public int Power { get { return _power; } set { _power = value; NotifyPropertyChanged(); } }
        public int Sneak { get {  return _sneak; } set {  _sneak = value; NotifyPropertyChanged(); } }
        public int Grit { get {  return _grit; } set {  _grit = value; NotifyPropertyChanged(); } }
        public int Mischief { get {  return _mischief; } set {  _mischief = value; NotifyPropertyChanged(); } }
        public int Cunning { get {  return _cunning; } set {  _cunning = value; NotifyPropertyChanged(); } }
        public int Skitter { get {  return _skitter; } set {  _skitter = value; NotifyPropertyChanged(); } }
        public int Gleam { get {  return _gleam; } set { _gleam = value; NotifyPropertyChanged(); } }
        public int Points { get {  return _points; } set { _points = value; NotifyPropertyChanged(); } }
        public int GetMaxPoints() { return _maxPoints; }
    }
}
