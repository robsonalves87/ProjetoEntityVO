using ProjetoEntityVO.Application.Interfaces;
using ProjetoEntityVO.Domain.Entities;
using ProjetoEntityVO.Domain.Interfaces.Services;

namespace ProjetoEntityVO.Application.Services
{
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {
        private readonly IClienteService _clienteService;

        public ClienteAppService(IClienteService clienteService) : base(clienteService)
        {
            _clienteService = clienteService;
        }
    }
}
