using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivosApi.Models;

public class AtivoModel
{
    public string AtivoNome { get; set; }
    public DateTime Data { get; set; }
    public decimal Valor { get; set; }
    public decimal? VariacaoDiaAnterior { get; set; }
    public decimal VariacaoPrimeiraData { get; set; }
}
