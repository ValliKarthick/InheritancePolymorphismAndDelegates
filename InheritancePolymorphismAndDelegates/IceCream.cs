using System;

namespace InheritancePolymorphismAndDelegates
{
    public class IceCream
    {
        public virtual void ShowDetails()
        {
            Console.WriteLine("Flavour - ");
            Console.WriteLine("Topping - ");
            Console.WriteLine("Sauce - ");
        }
    }
}
