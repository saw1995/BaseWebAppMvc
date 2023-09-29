using CreditoDigital.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditoDigital.Client
{
    public class CoreVedic: ICoreVedic
    {
		private ConfigEndpoint _endpoint;
		public CoreVedic(ConfigEndpoint endpoint)
		{
            _endpoint = endpoint;

        }
        public async Task<PruebaModel> Prueba(PruebaModel param)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Convertir el objeto a JSON
                    string json = JsonConvert.SerializeObject(param);

                    // Crear el contenido de la solicitud
                    StringContent content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                    // Enviar la solicitud POST
                    HttpResponseMessage response = await client.PostAsync(_endpoint.urlVedic + "api/Usuario/GetDatos", content);

                    // Verificar si la solicitud fue exitosa
                    if (!response.IsSuccessStatusCode)
                    {
                        return new PruebaModel { Description = "Error al consumir la api" + response.StatusCode };
                    }

                    // Leer la respuesta como string
                    string responseString = await response.Content.ReadAsStringAsync();

                    // Deserializar la respuesta a un objeto MiObjeto
                    return JsonConvert.DeserializeObject<PruebaModel>(responseString);

                }
            }
            catch (Exception ex)
            {
                return new PruebaModel { Description = ex.Message };
            }
        }


    }
}
