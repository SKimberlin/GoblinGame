using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinMode.UI
{
    internal class Character
    {
        private int power;   
        private int sneak;   
        private int grit;    
        private int mischief;
        private int cunning; 
        private int skitter; 
        private int gleam;   

        public Character() { }

        public int Power { get { return power; } set { power = value; } }
        public int Sneak { get {  return sneak; } set {  sneak = value; } }
        public int Grit { get {  return grit; } set {  grit = value; } }
        public int Mischief { get {  return mischief; } set {  mischief = value; } }
        public int Cunning { get {  return cunning; } set {  cunning = value; } }
        public int Skitter { get {  return skitter; } set {  skitter = value; } }
        public int Gleam { get {  return gleam; } set { gleam = value; } }
    }
}
