using Exercicios_LendoJSON.Models.Entities;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Text;


namespace Exercicios_LendoJSON.Models.Services
{
    class JsonProcess
    {
        /// <summary>
        /// Classe em que gera o JSON através de uma URL e CPF passados
        /// </summary>
        /// <param name="CEP"></param>
        /// <returns>Retorna o JSON como string</returns>
        public static string GerarJsoneToString(string CEP)
        {
            System.Net.HttpWebRequest requisicao = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/" + CEP + "/json/");
            HttpWebResponse resposta = (HttpWebResponse)requisicao.GetResponse();

            int cont;
            byte[] buffer = new byte[1000];
            StringBuilder sb = new StringBuilder();
            string temp;
            Stream stream = resposta.GetResponseStream();
            do
            {
                cont = stream.Read(buffer, 0, buffer.Length);
                temp = Encoding.Default.GetString(buffer, 0, cont).Trim();
                sb.Append(temp);

            } while (cont > 0);
            return sb.ToString();

        }

        /// <summary>
        /// Método para desserializar a string do JSON em objeto
        /// </summary>
        /// <param name="vJson"></param>
        /// <returns></returns>
        public static Entity Deserializador(string vJson)
        {
            return JsonConvert.DeserializeObject<Entity>(vJson);
        }
    }
}
