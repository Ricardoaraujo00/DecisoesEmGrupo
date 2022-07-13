using DecisoesEmGrupo.Shared.Models;
using DecisoesEmGrupo.Client.IService;
using System.Net.Http.Json;

namespace DecisoesEmGrupo.Client.Services
{
    public class PropostaService : IPropostaService
    {
        HttpClient http = new();

        public async Task<Proposta> GetProposta(int id)
        {
            Proposta? proposta = await http.GetFromJsonAsync<Proposta>($"api/proposta/{id}");
            if (proposta != null)
            {
                return proposta;
            }
            return new Proposta();
        }
        public async Task<HashSet<Proposta>> GetPropostasActivas()
        {
            HashSet<Proposta>? propostas  = await http.GetFromJsonAsync<HashSet<Proposta>>("api/proposta/propostasactivas");
            if(propostas!=null)
            {
                return propostas;
            }
            propostas = new();
            return propostas;
        }

        public async Task<HashSet<Proposta>> GetPropostasInactivas()
        {
            HashSet<Proposta>? propostas = await http.GetFromJsonAsync<HashSet<Proposta>>("api/proposta/propostasinactivas");
            if (propostas != null)
            {
                return propostas;
            }
            propostas = new();
            return propostas;
        }

        public async Task<Proposta> GuardarProposta(Proposta proposta)
        {
            var httpResponse = await http.PostAsJsonAsync($"api/Proposta", proposta);
            if (httpResponse.StatusCode.ToString() == "OK")
            {
                Proposta? responseObject = await httpResponse.Content.ReadFromJsonAsync<Proposta>();
                if(responseObject != null)
                {
                    return responseObject;
                }
            }
            return new Proposta();
        }

        public async Task<bool> EditarProposta(Proposta proposta)
        {
            var httpResponse = await http.PutAsJsonAsync<Proposta>($"api/Intervencao/{proposta.Id}", proposta);
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

        public async Task<bool> ApagarProposta(int propostaId)
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
