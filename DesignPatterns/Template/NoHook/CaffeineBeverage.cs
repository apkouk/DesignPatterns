using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Template.NoHook
{
    public abstract class CaffeineBeverage
    {
        //This method basically is the template or in other words the steps to accomplish the algorithm
        public void prepareRecipe()
        {
            boilWater();
            brew();
            pourInCup();
            addCondiments();
        }

        //The common methods for the subclasses are implemented in the high class (this one rules the show)
        private void boilWater()
        {
            Console.WriteLine("Boling water");
        }
        private void pourInCup()
        {
            Console.WriteLine("Pouring beverage in cup");
        }

        //As the subclasses will have to implement this methods, will marked them as abstract
        internal abstract void brew();
        internal abstract void addCondiments();
        
    }
}
