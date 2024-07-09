using System;
using RestSharp;
using System.Threading;
using System.Threading.Tasks;
namespace HelloWorld
{
    class Postman
    {
        static async Task Main(string[] args)
        {
            var options = new RestClientOptions("https://reqres.in");
           
            var client = new RestClient(options);
            var request = new RestRequest("/api/unknown", Method.Get);
            RestResponse response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content);
        }
    }
}