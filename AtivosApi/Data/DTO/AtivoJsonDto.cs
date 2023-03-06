namespace AtivosApi.Data.DTO;

public class AtivoJsonDto
{
    public class Chart
    {
        public Result[] Result { get; set; }
    }

    public class Result
    {
        public Meta Meta { get; set; }
        public List<int> Timestamp { get; set; }
        public Indicators Indicators { get; set; }
    }

    public class Indicators
    {
        public Quote[] Quote { get; set; }
    }

    public class Quote
    {
        public List<double> Open { get; set; }
        public List<double> Close { get; set; }
    }

    public class Meta
    {
        public string Symbol { get; set; }
    }

        
}
