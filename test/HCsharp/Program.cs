using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace HCsharp
{
    class Program {
        HttpClient client = new();

        static async Task Main(string[] args) {
            Program program = new Program();
            string[] units = { "mm", "cm", "m", "dm", "km" };

            await program.GetText();

            /*
            for (int i = 0; i < 10; i++) {
                foreach(string str in units) {
                    await program.GetApi(i, str);
                }
            }
            */
        }

        private async Task GetText() {
            string response = await client.GetStringAsync("https://raw.githubusercontent.com/Aghost/HttpClient_cSharp/main/Program.cs");

            Console.WriteLine(response);
        }

        private async Task GetApi(int i, string u) {
            string response = await client.GetStringAsync($"http://localhost:5000/convert/{i}/{u}/mm");
            Console.WriteLine(response);
        }
    }
}
