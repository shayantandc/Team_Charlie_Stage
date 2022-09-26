using Login.Models;
using MediatR;

namespace Login.Commands
{
    public class Register:IRequest<EcomLogin>
    {
        public string Emailid { get; set; }
        public string Password { get; set; }
        //public int Custid { get; set; }
    }
}
