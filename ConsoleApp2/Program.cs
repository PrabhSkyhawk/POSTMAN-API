using System;
using RestSharp;
using System.Threading;
using System.Threading.Tasks;
namespace HelloWorldApplication
{
    class HelloWorld
    {
        static async Task Main(string[] args)
        {
            var options = new RestClientOptions("https://reqres.in");

            var client = new RestClient(options);
            var request = new RestRequest("/api/users?page=2", Method.Get);
            RestResponse response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content);
        }
        static async Task Main2(string[] args)
        {
            var options = new RestClientOptions("https://reqres.in");

            var client = new RestClient(options);
            var request = new RestRequest("/api/users/2", Method.Get);
            RestResponse response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content);
        }
        static async Task Main3(string[] args)
        {
            var options = new RestClientOptions("https://reqres.in");

            var client = new RestClient(options);
            var request = new RestRequest("/api/users/23", Method.Get);
            RestResponse response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content);
        }
        static async Task Main4(string[] args)
        {
            var options = new RestClientOptions("https://reqres.in");

            var client = new RestClient(options);
            var request = new RestRequest("/api/unknown", Method.Get);
            RestResponse response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content);
        }
        static async Task Main5(string[] args)
        {
            var options = new RestClientOptions("https://reqres.in");

            var client = new RestClient(options);
            var request = new RestRequest("/api/unknown/2", Method.Get);
            RestResponse response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content);
        }
        static async Task Main6(string[] args)
        {
            var options = new RestClientOptions("https://reqres.in");

            var client = new RestClient(options);
            var request = new RestRequest("/api/unknown/23", Method.Get);
            RestResponse response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content);
        }
        static async Task Main7(string[] args)
        {
            var options = new RestClientOptions("https://reqres.in");

            var client = new RestClient(options);
            var request = new RestRequest("/api/users", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            var body = @"{
" + "\n" +
            @"    ""name"": ""morpheus"",
" + "\n" +
            @"    ""job"": ""leader""
" + "\n" +
            @"}";
            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content);
        }
        static async Task Main8(string[] args)
        {
            var options = new RestClientOptions("https://reqres.in");

            var client = new RestClient(options);
            var request = new RestRequest("/api/register", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            var body = @"{
" + "\n" +
            @"    ""email"": ""eve.holt@reqres.in"",
" + "\n" +
            @"    ""password"": ""pistol""
" + "\n" +
            @"}";
            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content);
        }
        static async Task Main9(string[] args)
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
        static async Task Main10(string[] args)
        {
            var options = new RestClientOptions("https://reqres.in");

            var client = new RestClient(options);
            var request = new RestRequest("/api/login", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            var body = @"{
" + "\n" +
            @"    ""email"": ""eve.holt@reqres.in"",
" + "\n" +
            @"    ""password"": ""cityslicka""
" + "\n" +
            @"}";
            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content);
        }
        static async Task Main11(string[] args)
        {
            var options = new RestClientOptions("https://reqres.in");

            var client = new RestClient(options);
            var request = new RestRequest("/api/login", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            var body = @"{
" + "\n" +
            @"    ""email"": ""peter@klaven""
" + "\n" +
            @"}";
            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content);
        }
        static async Task Main12(string[] args)
        {
            var options = new RestClientOptions("https://reqres.in");

            var client = new RestClient(options);
            var request = new RestRequest("/api/users/2", Method.Put);
            request.AddHeader("Content-Type", "application/json");
            var body = @"{
" + "\n" +
            @"    ""name"": ""morpheus"",
" + "\n" +
            @"    ""job"": ""zion resident""
" + "\n" +
            @"}";
            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content);
        }
    }
}