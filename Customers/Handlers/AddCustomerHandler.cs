using Login.Commands;
using Login.Models;
using Login.Repository;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Login.Handlers
{
    public class AddCustomerHandler : IRequestHandler<AddCustomer, EcomCustomers>
    {
        private readonly ICustomerServices _data;
        public AddCustomerHandler(ICustomerServices data)
        {
            _data = data;
        }

        public Task<EcomCustomers> Handle(AddCustomer request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.addCustomers(request.Name, request.Add, request.Phone,request.Email,request.Loginid));
        }
    }
}

    

