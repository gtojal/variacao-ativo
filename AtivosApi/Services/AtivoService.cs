using AtivosApi.Data.Entities;
using AtivosApi.Data.Repository.Interface;
using AtivosApi.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AtivosApi.Services;

public class AtivoService : IAtivoService
{
    public IAtivoRepository _repository;

    public AtivoService(IAtivoRepository repository)
    {
        _repository = repository;
    }

    public async Task<IActionResult> AdicionarAtivo(string responseBody)
    {

        var meuObjConvertido = JsonConvert.DeserializeObject<Ativo>(responseBody);
        var arq = JsonConvert.DeserializeObject(responseBody);

        

        var ativo = new Ativo();
        ativo.Id = Guid.NewGuid().ToString();
        //ativo.AtivoNome = ativoConsulta;
        ativo.Data = DateTime.Now.Date;
        ativo.VariacaoDiaAnterior = 10; //calcular variação em relação ao dia anterior
        ativo.VariacaoPrimeiraData = 30; //calcular Variação em relação a primeira data salva no banco

        return await _repository.AdicionarAtivo(ativo);
    }
}
