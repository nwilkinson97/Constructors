namespace Constructors
{
    // After having used the Quick Actions to move the Customer Class to a new file
    // you can use the keyboard shortcut to open the Solution Explorer {CTRL} + {ALT} + L
    // that will place the focus in the solutions explorer.  You can then highlight the
    // Customer.cs and Press {F7} on the keyboard.  The {F7} shorcut will open the Code
    // Window with the Customer.cs contents.
    class Program
    {
        static void Main(string[] args)
        {
            // By using the generic variable we can name the variable on the left 
            // and assign the type on the right.  
            // The Other way by assigning the type on both the left and the right
            // can clutter the code and is not considered to be a best practice.
            var customer = new Customer();

            // Display the Customer ID and Name
            // Using the Code Snippet cw {TAB}
            System.Console.WriteLine(customer.Id);
            System.Console.WriteLine(customer.Name);
        }
    }
}
