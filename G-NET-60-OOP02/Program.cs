namespace G_NET_60_OOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01
            #region Question01


            //Q1 : Consider the following class:
            //
            //a) Identify at least two problems with this design from an encapsulation perspective.
            //b) Describe how you would fix this class to follow proper encapsulation principles.You do not need to write the full code.
            //c) Explain why exposing fields directly(as public) is considered a bad practice in OOP.

            //a) At least two problems with this design (encapsulation perspective)
            //Public fields (Owner and Balance)

            //Any code can directly modify these values:

            //account.Balance = -1000;
            //        account.Owner = "";
            //        This bypasses any validation or business rules.
            //2-No validation in Withdraw()
            //The method subtracts the amount without checking:
            //If the amount is positive.
            //If sufficient funds are available.
            //This can result in invalid account states(e.g., negative balances).
            //3-Internal state is not protected
            //Since Balance is public, external code can change it directly instead of using controlled methods such as Deposit() or Withdraw().
            #endregion

            #region Question02

            // Q02 : What is the difference between a field and a property in 
            //     C#? Can a property contain logic? Give an example of a
            //     read-only property that returns a calculated value.


            /*
             // Field:
            // A variable that directly stores data inside a class.

            // Property:
            // A member that provides controlled access to data using get and set.
            // A property can contain logic such as validation or calculations.

            // Example of a read-only calculated property:
            // public double Area => Width * Height;

             */



            #endregion


            #region Question03

            //Q3 : Look at the following code and answer the questions below:


            // a)
            // this[int index] is called an Indexer.
            // It allows objects of the class to be accessed like an array.
            // Example: register[0] = "Ali";

            // b)
            // register[10] = "Ali"; will throw an IndexOutOfRangeException
            // because the array size is only 5 elements (indexes 0 to 4).
            // To make it safer, add a range check inside the get and set accessors.

            // c)
            // Yes, a class can have more than one indexer.
            // Example: a Student class could have one indexer by student ID
            // and another indexer by student name.
            // This is useful when data needs to be accessed in different ways.

            #endregion

            #region Qustion04


            //Q4 : Consider the following code and answer the questions below

            //a) What does the `static` keyword mean on `TotalOrders`? How is it different from the `Item` field?
            //b) Can a static method inside `Order` access the `Item` field directly? Why or why not?

            /*
             // a)
        // The static keyword means TotalOrders belongs to the class itself,
        // not to individual objects.
        // All Order objects share the same TotalOrders variable.
        //
        // Item is a non-static (instance) field.
        // Each Order object has its own separate Item value.

        // b)
        // No, a static method cannot access the Item field directly.
        // Because Item belongs to an object instance, while a static method
        // belongs to the class and has no specific object to work with.
        //
        // A static method would need an Order object reference to access Item.

             */
            #endregion


            #endregion
           




        }
    }
}
