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
            var request = new RestRequest("/api/register", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            var body = @"{
" + "\n" +
            @"    ""email"": ""sydney@fife""
" + "\n" +
            @"}";
            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content);
        }
    }
}
