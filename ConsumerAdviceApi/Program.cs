using System;
using Newtonsoft.Json;

namespace ConsumerAdviceApi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Simulando o JSON que a API retornaria
            string jsonResponse = @"{
              ""slip"": {
                ""id"": 1,
                ""advice"": ""Things are just things. Don't get too attached to them.""
              }
            }";

            // Chama o método para processar o JSON simulado
            var conselho = GetConselhoFromJson(jsonResponse);

            // Exibe o conselho na tela
            Console.WriteLine("Conselho de Hoje:");
            Console.WriteLine(conselho);
        }

        // Método para deserializar o JSON manual e obter o conselho
        static string GetConselhoFromJson(string jsonResponse)
        {
            // Deserializa o JSON manual para um objeto
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            dynamic data = JsonConvert.DeserializeObject(jsonResponse);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

            // Retorna o conselho do JSON deserializado
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            return data.slip.advice;
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }
    }
}