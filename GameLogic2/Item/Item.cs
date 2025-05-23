using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinMode.Item
{
    public abstract class Item
    {
        private string name;
        private float weight;
        private float worth;
        private bool isRemoveable = true;

        public string GetName() { return name; }
        public void SetName(string name) { this.name = name; }
        public float GetWeight() { return weight; }
        public void SetWeight(float weight) {  this.weight = weight; }
        public float GetWorth() { return worth; }
        public void SetWorth(float worth) { this.worth = worth; }
        public bool IsRemoveable() {  return isRemoveable; }
        public void SetRemoveable(bool removable) {  isRemoveable = removable; }
        

    }
}
