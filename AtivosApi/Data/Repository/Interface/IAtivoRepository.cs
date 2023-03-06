using Microsoft.AspNetCore.Mvc;

namespace AtivosApi.Data.Repository.Interface
{
    public interface IAtivoRepository
    {
        Task<IActionResult> AdicionarAtivo(object ativo);
    }
}
