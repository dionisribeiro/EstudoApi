using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UsuarioApi.Application.Interface.Repository;
using UsuarioApi.Domain;
using UsuarioApi.Infra.Data.Repository;

namespace UsuarioApi.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuariosController(UsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpGet]
        public IEnumerable<Usuario> GetAll()
        {
            return _usuarioRepository.GetAll();
        }

        [HttpGet("{id}", Name ="GetUsuario")]
        public IActionResult GetById(int id)
        {
            var usuario = _usuarioRepository.GetById(id);

            if (usuario == null)
                return NotFound();
            
            return new ObjectResult(usuario);
        }
    }
}