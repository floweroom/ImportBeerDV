using BeerDB;
using System.Net.Http.Json;

Console.WriteLine("Нажмите enter для начала работы");
Console.ReadLine();

const string adress_str = "https://localhost:7143";
var client = new HttpClient();
client.BaseAddress = new Uri(adress_str);

var response = await client.GetAsync("Home/GetId/4");
response.EnsureSuccessStatusCode();
var model = await response.Content.ReadFromJsonAsync<ModelsBeer>();


Console.WriteLine("Hello, World!");
