using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.Write("Digite o nome do Pokemon: ");
        string? nome = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(nome))
        {
            Console.WriteLine("Nome inválido.");
            return;
        }

        string url = $"https://pokeapi.co/api/v2/pokemon/{nome.ToLower()}";

        HttpClient client = new HttpClient();

        try
        {
            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();

                Pokemon? pokemon = JsonSerializer.Deserialize<Pokemon>(json);

                if (pokemon == null)
                {
                    Console.WriteLine("Erro ao processar dados.");
                    return;
                }

                Console.WriteLine("\nDados do Pokemon:");
                Console.WriteLine($"Id: {pokemon.Id}");
                Console.WriteLine($"Nome: {pokemon.Name}");
                Console.WriteLine($"Altura: {pokemon.Height}");
                Console.WriteLine($"Peso: {pokemon.Weight}");
            }
            else
            {
                Console.WriteLine("Pokemon não encontrado.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
        }
    }
}