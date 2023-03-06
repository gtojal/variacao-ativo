﻿namespace AtivosApi.Data.DTO
{
    public class AtivoJsonConverterDto
    {
        public Chart chart { get; set; }
    }

    public class Chart
    {
        public List<Result> result { get; set; }
    }

    public class Result
    {
        public Meta meta { get; set; }
        public List<int> timestamp { get; set; }
        public Indicators indicators { get; set; }
    }

    public class Indicators
    {
        public List<Quote> quote { get; set; }
    }

    public class Meta
    {
        public string symbol { get; set; }
    }

    public class Quote
    {
        public List<double?> open { get; set; }
    }

}