using System; // importowanie
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cwiczenia1  // w Javie package
    // strin małą literą
    // metody wielkimi literami
{



    public class Student
    {
        private string Name;


        public string GetName()
        {
            return Name;
        }

    }

    /*
     * Student st = new Student();   Java
     * ... String Name = st.getName();
     *     st.Name = "ss"
     * 
     * 
     */

    public class Program
    {
        public static async Task Main(string[] args)
        {

            var client = new HttpClient();
            HttpResponseMessage result = await client.GetAsync("https://www.pja.edu.pl");

            if (result.IsSuccessStatusCode)
            {
                string html = await result.Content.ReadAsStringAsync();

              
                var regex = new Regex("[a-z]+[a-z0-9]*@[a-z0-0]+\\.[a-z]+", RegexOptions.IgnoreCase);

                MatchCollection matches = regex.Matches(html);
                foreach (var m in matches)
                {
                    Console.WriteLine(m.ToString());
                }
            }


            // JS promise async/wait
            //Java Future
            //C# Task async/await


            Console.WriteLine("Koniec programu!");
        }
    }
}
