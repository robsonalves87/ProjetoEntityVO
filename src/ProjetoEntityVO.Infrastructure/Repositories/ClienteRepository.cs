using ProjetoEntityVO.Domain.Entities;
using ProjetoEntityVO.Domain.Interfaces.Repositories;
using ProjetoEntityVO.Infrastructure.Context;

namespace ProjetoEntityVO.Infrastructure.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
        public ClienteRepository(ProjetoEntityVOContext context) : base(context)
        {
        }
    }
}
