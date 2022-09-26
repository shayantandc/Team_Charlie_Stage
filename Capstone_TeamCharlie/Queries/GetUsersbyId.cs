using Login.Models;
using MediatR;

namespace Login.Queries
{
    public class GetUsersbyId:IRequest<EcomLogin>
    {
        public int Id { get; set; }
    }
}
