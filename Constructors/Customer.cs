// You can use the {CTRL} + TAB to alternate between open Code windows.
using System.Collections.Generic;

namespace Constructors
{
    public class Customer
    {
        public int Id;
        public string Name;

        // Here you will notice when you first add a List it is not recognized as a valid type.
        // to resolve this use the Quick Actions shortcut {CTRL} + . and add the appropriate 
        // using statement.  

        // NOTE:  You could initialize the Orders Field here.  Instead of using inheritance.  However,
        //    -- for this lessone I wanted to show how we can use the this keyword to inherit or link
        //     --> our class constructors.

        // The readonly modifier here tells the compiler that this field can only be defined
        // when the class is initialized.
        public readonly List<Order> Orders;

        /// <summary>
        /// Default Constructor for the customer class. 
        /// Note:  Code Snippet ctor {TAB}
        /// </summary>
        public Customer()
        {
            Orders = new List<Order>();
        }

        public Customer(int id): this()
        {
            // Note for readability use the this keyword.  Also using this keyword will access the list of fields
            // or properties avaialble and hide the integer 'id' value passed.
            this.Id = id;
        }

        public Customer(int id, string name): this(id)
        {
            this.Name = name;
        }
    }
}
