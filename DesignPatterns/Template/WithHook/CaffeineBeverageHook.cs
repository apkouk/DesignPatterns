using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Template.NoHook
{
    public abstract class CaffeineBeverageHook
    {
        //This method basically is the template or in other words the steps to accomplish the algorithm
        public void prepareRecipe()
        {
            boilWater();
            brew();
            pourInCup();
            if(CustomerWantsCondiment())
                addCondiments();
        }

        //The common mewthods for the subclasses are implmented in the high class (this one rules the show)
        private void boilWater()
        {
            Console.WriteLine("Boling water");
        }
        private void pourInCup()
        {
            Console.WriteLine("Pouring beverage in cup");
        }

        //As the sublcasses will have to implement this methods will marked them as abstract
        internal abstract void brew();
        internal abstract void addCondiments();


        //This is the hook. A hook is a method in the abstract class that gives sibclasses the ability
        //to "hook into" the algorithim if the wish. It might given empty or with a default implementation.
        public virtual bool CustomerWantsCondiment()
        {
            return true;
        }


        
    }
}
