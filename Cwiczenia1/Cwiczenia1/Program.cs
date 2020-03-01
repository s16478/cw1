using System; // importowanie
using System.Net.Http;
using System.Threading.Tasks;

namespace Cwiczenia1  // w Javie package
    // strin małą literą
    // metody wielkimi literami
{
    public class Program
    {
        public static async Task Main(string[] args)
        {

            var client = new HttpClient();
            HttpResponseMessage result = await client.GetAsync("https://www.pja.edu.pl");

            if (result.IsSuccessStatusCode)
            {
                string html = await result.Content.ReadAsStringAsync();
            }

          
            

            // JS promise async/wait
            //Java Future
            //C# Task async/await


            Console.WriteLine("Koniec programu!");
        }
    }
}
