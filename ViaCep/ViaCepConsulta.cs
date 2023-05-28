using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ViaCep
{
    public class ViaCepConsulta
    {
        public async Task<Endereco> ObterEnderecoPorCepAsync(string cep)
        {
            string url = $"https://viacep.com.br/ws/{cep}/json/";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    dynamic data = JsonConvert.DeserializeObject(json);

                    return new Endereco
                    {
                        Logradouro = data.logradouro,
                        Bairro = data.bairro,
                        Localidade = data.localidade,
                        UF = data.uf
                    };
                }
                else
                {
                    throw new Exception("Não foi possível obter as informações do CEP fornecido.");
                }
            }
        }
    }
}
