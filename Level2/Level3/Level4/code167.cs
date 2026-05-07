using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        HttpClient client = new HttpClient();

        // API URL
        string url = "https://jsonplaceholder.typicode.com/posts/1";

        // GET request
        HttpResponseMessage response = await client.GetAsync(url);

        // Read response data
        string data = await response.Content.ReadAsStringAsync();

        Console.WriteLine(data);
    }
}
