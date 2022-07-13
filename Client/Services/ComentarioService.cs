using DecisoesEmGrupo.Shared.Models;
using DecisoesEmGrupo.Client.IService;
using System.Net.Http.Json;

namespace DecisoesEmGrupo.Client.Services
{
    public class ComentarioService : IComentarioService
    {
        HttpClient http = new();

        public async Task<Comentario> GetComentario(int id)
        {
            Comentario? comentario = await http.GetFromJsonAsync<Comentario>($"api/comentario/{id}");
            if (comentario != null)
            {
                return comentario;
            }
            return new Comentario();
        }
        public async Task<HashSet<Comentario>> GetComentariosProposta(int propostaId)
        {
            HashSet<Comentario>? comentarios = await http.GetFromJsonAsync<HashSet<Comentario>>($"api/comentario/proposta/{propostaId}");
            if (comentarios != null)
            {
                return comentarios;
            }
            comentarios = new();
            return comentarios;
        }

        public async Task<Comentario> GuardarComentario(Comentario comentario)
        {
            var httpResponse = await http.PostAsJsonAsync($"api/Comentario", comentario);
            if (httpResponse.StatusCode.ToString() == "OK")
            {
                Comentario? responseObject = await httpResponse.Content.ReadFromJsonAsync<Comentario>();
                if (responseObject != null)
                {
                    return responseObject;
                }
            }
            return new Comentario();
        }

        public async Task<bool> EditarComentario(Comentario comentario)
        {
            var httpResponse = await http.PutAsJsonAsync<Comentario>($"api/Intervencao/{comentario.Id}", comentario);
            if (httpResponse.StatusCode.ToString() == "OK")
            {
                bool responseObject = await httpResponse.Content.ReadFromJsonAsync<bool>();
                if (responseObject)
                {
                    return responseObject;
                }
            }
            return false;
        }

        public async Task<bool> ApagarComentario(int propostaId)
        {
            var httpResponse = await http.DeleteAsync($"api/ManutencaoProgramada/{propostaId}");
            if (httpResponse.StatusCode.ToString() == "OK")
            {
                bool responseObject = await httpResponse.Content.ReadFromJsonAsync<bool>();
                if (responseObject)
                {
                    return responseObject;
                }
            }
            return false;
        }
    }
}
