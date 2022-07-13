using DecisoesEmGrupo.Shared.Models;

namespace DecisoesEmGrupo.Client.IService
{
    public interface IComentarioService
    {
        Task<Comentario> GetComentario(int id);

        Task<HashSet<Comentario>> GetComentariosProposta(int propostaId);

        Task<Comentario> GuardarComentario(Comentario comentario);

        Task<bool> ApagarComentario(int propostaId);

    }
}
