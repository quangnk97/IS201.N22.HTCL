using IS201_N22_HTCL.Interface;
using System.Collections.Generic;

namespace IS201_N22_HTCL.Model
{
    internal class UpComingDisc : IUpComingDisc
    {
        private List<ICustomer> customers = new List<ICustomer>();
        private string discName;

        private string DiscName { get; set; }

        public UpComingDisc(string discName)
        {
            this.discName = discName;
        }
        public void Attach(ICustomer customer)
        {
            customers.Add(customer);
        }

        public void Detach(ICustomer customer)
        {
            customers.Remove(customer);
        }

        public void Notify()
        {
            foreach (ICustomer customer in customers)
            {
                customer.Update(discName);
            }
        }
    }
}
