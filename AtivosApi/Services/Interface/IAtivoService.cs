using Microsoft.AspNetCore.Mvc;

namespace AtivosApi.Services.Interface;

public interface IAtivoService
{
    Task<IActionResult> AdicionarAtivo(string responseBody);
}
