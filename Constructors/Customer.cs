// You can use the {CTRL} + TAB to alternate between open Code windows.
using System.Collections.Generic;

namespace Constructors
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        /// <summary>
        /// Default Constructor for the customer class. 
        /// Note:  Code Snippet ctor {TAB}
        /// </summary>
        public Customer()
        {

        }

        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
