using Login.Models;
using MediatR;

namespace Login.Commands
{
    public class AddCustomer:IRequest<EcomCustomers>
    {
        public string Name { get; set; }
        public string Add { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Loginid { get; set; }    }
}
