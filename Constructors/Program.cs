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

            // On this line to see the list of constructors available remove the 
            // Opening parenthesis and retype it.  You will see a list of available
            // Constructors.
            var customer = new Customer(1, "Kid Dynamite");

            // Display the Customer ID and Name
            // Using the Code Snippet cw {TAB}
            // Note:  Place a Breakpoint on the Name property for Customer 
            // -- {F9} Toggles Breakpoints
            // --- Press {CTRL} + {F5} to Run the Program without Debugging
            // ----- This time the program runs and ignores the breakpont (WITHOUT DEBGUGGING)
            // --- Press {F5} to Run the Program
            // ----- This time the program runs and stops on the breakpoint 
            // Note:  To Stop the Debugger press {SHIFT} + {F5}
            System.Console.WriteLine(customer.Id);
            System.Console.WriteLine(customer.Name);
        }
    }
}
