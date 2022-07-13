using DecisoesEmGrupo.Shared.Models;

namespace DecisoesEmGrupo.Client.IService
{
    public interface IPropostaService
    {
        Task<Proposta> GetProposta(int id);

        Task<HashSet<Proposta>> GetPropostasActivas();

        Task<HashSet<Proposta>> GetPropostasInactivas();

        Task<Proposta> GuardarProposta(Proposta proposta);

        Task<bool> EditarProposta(Proposta proposta);

        Task<bool> ApagarProposta(int propostaId);

    }
}
