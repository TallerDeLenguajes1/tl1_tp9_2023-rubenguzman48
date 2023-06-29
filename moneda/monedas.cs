using System.Text.Json;
using System.Text.Json.Serialization;

namespace moneda
{
    public class Time
    {
        [JsonPropertyName("update")]
        public string updated {get; set;}

        [JsonPropertyName("updateISO")]
        public DateTime updateISO {get; set;}

        [JsonPropertyName("updateduk")]
        public string updateuk {get; set;}
    }

    public class BPI
    {
        [JsonPropertyName("USD")]
        public USD usd {get; set;}

        [JsonPropertyName("GBP")]
        public GBP gbp {get; set;}
        
        [JsonPropertyName("EUR")]
        public EUR eur {get; set;}
    }
    public class USD
    {
        [JsonPropertyName("code")]
        public string code {get; set;}

        [JsonPropertyName("symbol")]
        public string symbol {get; set;}

        [JsonPropertyName("rate")]
        public string rate {get; set;}


        [JsonPropertyName("description")]
        public string rate_float {get; set;}
    }

    public class GBP
    {
        [JsonPropertyName("code")]
        public string code {get; set;}

        [JsonPropertyName("symbol")]
        public string symbol {get; set;}

        [JsonPropertyName("rate")]
        public string rate {get; set;}


        [JsonPropertyName("description")]
        public string rate_float {get; set;}
    }
    public class EUR
    {
        [JsonPropertyName("code")]
        public string code {get; set;}

        [JsonPropertyName("symbol")]
        public string symbol {get; set;}

        [JsonPropertyName("rate")]
        public string rate {get; set;}


        [JsonPropertyName("description")]
        public string description {get; set;}
    }

    public class BTC
    {
        [JsonPropertyName("time")]
        public Time time {get; set;}
        
        [JsonPropertyName("disclaimer")]
        public string disclaimer {get; set;}

        [JsonPropertyName("chartName")]
        public string chartName {get; set;}

        [JsonPropertyName("bpi")]
        public BPI bpi {get; set;}
    }
}