using BeerDB;
using System.Collections.Generic;
using System.Net.Http.Json;

Console.WriteLine("Нажмите enter для начала работы");
Console.ReadLine();

const string adress_str = "https://localhost:7143";
var client = new HttpClient();
client.BaseAddress = new Uri(adress_str);

var response = await client.GetAsync("api/modelbeer/get");
response.EnsureSuccessStatusCode();
var models = await response.Content.ReadFromJsonAsync <IEnumerable<ModelsBeer>>();



Console.WriteLine("Hello, World!");
