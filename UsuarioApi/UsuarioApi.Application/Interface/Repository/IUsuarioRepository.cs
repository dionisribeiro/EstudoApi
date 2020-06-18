using System.Collections.Generic;
using UsuarioApi.Domain;

namespace UsuarioApi.Application.Interface.Repository
{
    public interface IUsuarioRepository
    {
        void Add(Usuario usuario);
        IEnumerable<Usuario> GetAll();
        Usuario GetById(int id);
        void Remove(Usuario usuario);
        void Update(Usuario usuario);
    }
}
