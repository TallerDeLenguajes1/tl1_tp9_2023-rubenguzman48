using System.Text.Json;
using System.Net;
using moneda;


internal class Program
{
    private static void Main(string[] args)
    {
        BTC bitcoin = datosBTC();
        Console.WriteLine("Precio de BTC");
        Console.WriteLine($"Precio en dolares: {bitcoin.bpi.usd.rate}");
        Console.WriteLine($"Precio en euros: {bitcoin.bpi.eur.rate}");
        Console.WriteLine($"Precio en libras: {bitcoin.bpi.gbp.rate}");

        Console.WriteLine("\nCaracteristicas del Euro");
        Console.WriteLine($"Código: {bitcoin.bpi.eur.code}");
        Console.WriteLine($"Símbolo: {bitcoin.bpi.eur.symbol}");
        Console.WriteLine($"Tasa en relación al BTC: {bitcoin.bpi.eur.rate}");
        Console.WriteLine($"Descripción: {bitcoin.bpi.eur.description}");

    }


    private static BTC datosBTC()
    {
        var url = "https://api.coindesk.com/v1/bpi/currentprice.json";
        var peticion = (HttpWebRequest)WebRequest.Create(url);
        peticion.Method = "GET";
        peticion.ContentType = "application/json";
        peticion.Accept = "application/json";
        BTC bitcoin = null;

        try
        {
            using (WebResponse response = peticion.GetResponse())
            {
                using (Stream strReader = response.GetResponseStream())
                {
                    if (strReader == null) return null;
                    using(StreamReader objReader = new StreamReader(strReader))
                    {
                        string infoBTC = objReader.ReadToEnd();
                        bitcoin = JsonSerializer.Deserialize<BTC>(infoBTC);
                        objReader.Dispose();
                    }
                        
                }
            }
        }catch (WebException exce)
        {
            Console.WriteLine("No se puede acceder a la API");
        }
        return bitcoin;

    }

}

