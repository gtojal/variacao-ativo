using AtivosApi.Data.Entities;
using AtivosApi.Data.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace AtivosApi.Data.Repository;

public class AtivoRepository : IAtivoRepository
{
    async Task<IActionResult> IAtivoRepository.AdicionarAtivo(object ativo)
    {
        throw new NotImplementedException();
    }
}
