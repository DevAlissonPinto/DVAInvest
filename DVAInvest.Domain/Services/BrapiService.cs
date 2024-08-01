using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using DVAInvest.Domain.Entities;
using DVAInvest.Domain.Interfaces.Services;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace DVAInvest.Domain.Services
{
    public class BrapiService : IBrapiService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiToken;

        public BrapiService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _apiToken = configuration["BrapiSettings:ApiToken"];
        }

        public async Task<RespostaBrapi> ObterCotacaoAcaoAsync(string acao)
        {
            try
            {
                // Atualizar a URL para seguir o exemplo fornecido
                var url = $"https://brapi.dev/api/quote/{acao}?token={_apiToken}";
                Console.WriteLine($"Requisição para URL: {url}"); // Log da URL

                var response = await _httpClient.GetAsync(url);
                Console.WriteLine($"Status Code: {response.StatusCode}"); // Log do Status Code

                if (!response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Erro ao buscar cotação: {response.StatusCode}, Conteúdo: {responseContent}");
                    return null;
                }

                var responseString = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Resposta da API: {responseString}"); // Log da Resposta
                var data = JsonConvert.DeserializeObject<RespostaBrapi>(responseString);
                return data;
            }
            catch (HttpRequestException httpEx)
            {
                Console.WriteLine($"Erro HTTP ao buscar cotação: {httpEx.Message}");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao buscar cotação: {ex.Message}");
                return null;
            }
        }
    }

}
