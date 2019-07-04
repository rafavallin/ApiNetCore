using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreAPI.Models;
using NetCoreAPI.Repository;

namespace NetCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRep)
        {
            _usuarioRepository = usuarioRep;    
        }

        [HttpGet]
        public IEnumerable<Usuario> GetAll()
        {
            return _usuarioRepository.GetAll();
        }

        [HttpGet("{id}", Name ="GetUsuario")]
        public IActionResult GetById(long id)
        {
            var usuario = _usuarioRepository.Find(id);
            if(usuario == null)
            {
                return NotFound();
            }

            return new ObjectResult(usuario);
        }
    }
}