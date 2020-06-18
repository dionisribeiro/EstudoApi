using System;
using System.Collections.Generic;
using System.Linq;
using UsuarioApi.Application.Interface.Repository;
using UsuarioApi.Domain;
using UsuarioApi.Infra.Data.UsuarioDbContexto;

namespace UsuarioApi.Infra.Data.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly UsuarioDbContext _usuarioDbContext;
        public UsuarioRepository(UsuarioDbContext usuarioDbContext)
        {
            _usuarioDbContext = usuarioDbContext;
        }
        public void Add(Usuario usuario)
        {
            _usuarioDbContext.Add(usuario);
            _usuarioDbContext.SaveChanges();
        }

        public IEnumerable<Usuario> GetAll()
        {
            return _usuarioDbContext.Usuarios.ToList();
        }

        public Usuario GetById(int id)
        {
            return _usuarioDbContext.Set<Usuario>().Find(id);
        }

        public void Remove(Usuario usuario)
        {
            _usuarioDbContext.Set<Usuario>().Remove(usuario);
            _usuarioDbContext.SaveChanges();
        }

        public void Update(Usuario usuario)
        {
            _usuarioDbContext.Usuarios.Update(usuario);
            _usuarioDbContext.SaveChanges();
        }
    }
}
