using System;

namespace InheritancePolymorphismAndDelegates
{
    public class BlackCurrant : Butterscotch
    {
        public override void ShowDetails()
        {
            Console.WriteLine("Flavour - Black Currant");
            Console.WriteLine("Topping - Dry Fruits");
            Console.WriteLine("Sauce - Chocolate Sauce");
        }
    }
}
