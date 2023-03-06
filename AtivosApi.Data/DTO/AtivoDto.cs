using System.ComponentModel.DataAnnotations;

namespace AtivosApi.Data.DTO;

public class AtivoDto
{
    public string AtivoNome { get; set; }
    public DateTime Data { get; set; }
    public decimal Valor { get; set; }
    public decimal? VariacaoDiaAnterior { get; set; }
    public decimal VariacaoPrimeiraData { get; set; }
}
