using System;

namespace InheritancePolymorphismAndDelegates
{
    public class Butterscotch : IceCream
    {
        public override void ShowDetails()
        {
            Console.WriteLine("Flavour - Butterscotch");
            Console.WriteLine("Topping - Nuts");
            Console.WriteLine("Sauce - Caramel Sauce");
        }

        //public void DisplayDiscount()
        //{
        //    Console.WriteLine("Since you are Buying Butterscotch, we have a discount")
        //}
    }
}
