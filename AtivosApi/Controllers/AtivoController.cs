using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using AtivosApi.Data.DTO;
using AtivosApi.Data.Contexts;
using AtivosApi.Data.Entities;

namespace AtivosApi.Controllers;

[ApiController]
[Route("[controller]")]
public class AtivoController : ControllerBase
{
    private AtivoContext _context;
    private IMapper _mapper;

    public AtivoController(IMapper mapper, AtivoContext context)
    {
        _mapper = mapper;
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> AdicionarAtivoAsync(string ativo)
    {
        HttpClient client = new HttpClient();
        HttpResponseMessage response = await client.GetAsync("https://query2.finance.yahoo.com/v8/finance/chart/" + ativo);
        response.EnsureSuccessStatusCode();
        string responseBody = await response.Content.ReadAsStringAsync();

        var ativoJson = Newtonsoft.Json.JsonConvert.DeserializeObject<AtivoJsonConverterDto>(responseBody);


        try
        {
            if (string.IsNullOrWhiteSpace(responseBody))
            {
                return StatusCode(404, "Ativo não localizado");
            }

            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(ativoJson.chart.result.FirstOrDefault().timestamp[0]).ToLocalTime();

            var valor = ativoJson.chart.result.FirstOrDefault().indicators.quote.FirstOrDefault().open[0];

            var a = new Ativo();
            a.Id = Guid.NewGuid().ToString();
            a.AtivoNome = ativoJson.chart.result.FirstOrDefault().meta.symbol;
            a.Data = dateTime.Date;
            a.Valor = valor;
            a.VariacaoDiaAnterior = 0; //calcular Variação em relação ao di anterior.
            a.VariacaoPrimeiraData = 0; //calcular Variação em relação a primeira data salva no banco

            await _context.Ativos.AddAsync(a);
            _context.SaveChanges();
            return Ok();
        }
        catch (Exception e)
        {
            return StatusCode(500, "Ocorreu um erro: " + e.Message);
        }
    }

    [HttpGet("{ativoNome}")]
    public async Task<ActionResult<Ativo>> RecuperarAtivoAsync(string ativoNome)
    {
        var ativo = _context.Ativos
            .Select(a => a.AtivoNome == ativoNome);

        try 
        {
            if(ativo == null)
            {
                return StatusCode(404, "Ativo não localizado");
            }
           
            return Ok(ativo);
        }
        catch (Exception e)
        {
            return StatusCode(500, "Ocorreu um erro: " + e.Message);
        }
    }

}
