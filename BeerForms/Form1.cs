using System.Net.Http.Json;
using BeerDB;
using ImportBeerDV.Models;

namespace BeerForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private async void button1_Click(object sender, EventArgs e)
        {

            const string adress_str = "https://localhost:7143";
            var client = new HttpClient();
            client.BaseAddress = new Uri(adress_str);

            var response = await client.GetAsync("api/modelbeer/get");
            response.EnsureSuccessStatusCode();
            var models = await response.Content.ReadFromJsonAsync<IEnumerable<ModelsBeer>>();

            ProductsList.Items.Clear();

            foreach (var item in models)
            {
                ProductsList.Items.Add(item.Name);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            const string adress_str = "https://localhost:7143";
            var client = new HttpClient();
            client.BaseAddress = new Uri(adress_str);

            BeerDto beerDto = new BeerDto
            {
                Category = "Лимонад",

                Brand = "Волчек",

                Name = "Смородина",

                Region = "Россия",

                Calories = 250,

                Colour = "Красный",


                Volume = 0.5M,

                Taste = "Ягодный",
            };



            var response = await client.PostAsJsonAsync("api/ModelBeer", beerDto);




        }

        private async void button3_Click(object sender, EventArgs e)
        {
            const string adress_str = "https://localhost:7143";
            var client = new HttpClient();
            client.BaseAddress = new Uri(adress_str);
            var id = 1;

            var response = await client.DeleteAsync($"api/ModelBeer?id={id}");


        }

        private async void button5_Click(object sender, EventArgs e)
        {
            const string adress_str = "https://localhost:7143";
            var client = new HttpClient();
            client.BaseAddress = new Uri(adress_str);

            var response = await client.GetAsync("api/modelbeer/get");
            response.EnsureSuccessStatusCode();
            var models = await response.Content.ReadFromJsonAsync<IEnumerable<ModelsBeer>>();

            ProductsList.Items.Clear();

            foreach (var item in models)
            {
                ProductsList.Items.Add(item.Region);
            }
        }
    }
}

