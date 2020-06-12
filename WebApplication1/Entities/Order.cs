using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Entities
{
    public class Order
    {
        public int IdOrder { get; set; }
        public DateTime DateAccepted { get; set; }
        public DateTime DateFinished { get; set; }
        public string Notes { get; set; }
        public int IdClient { get; set; }
        public Nullable<int> IdEmployee { get; set; }

        public Customer Customer { get; set; }
        public Employee Employee { get; set; }

        // Every Dcotor will have a list of prescriptions that he/she prescribed ( List might be empty ) 
        public ICollection<Confectionary_Order> Confectionary_Orders { get; set; }
    }
}
