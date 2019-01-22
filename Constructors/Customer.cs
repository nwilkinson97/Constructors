// You can use the {CTRL} + TAB to alternate between open Code windows.
namespace Constructors
{
    public class Customer
    {
        public int Id;
        public string Name;

        /// <summary>
        /// Default Constructor for the customer class. 
        /// Note:  Code Snippet ctor {TAB}
        /// </summary>
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
