using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetCoreAPI.Models;

namespace NetCoreAPI.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly UsuarioDbContext _context;

        public UsuarioRepository(UsuarioDbContext ctx)
        {
            _context = ctx;  
        }
        public void Add(Usuario user)
        {
            _context.Usuarios.Add(user);
            _context.SaveChanges();
        }

        public Usuario Find(long id)
        {
            return _context.Usuarios.FirstOrDefault(u => u.UsuarioId == id);
        }

        public IEnumerable<Usuario> GetAll()
        {
            return _context.Usuarios.ToList();
        }

        public void Remove(long id)
        {
            var entity = _context.Usuarios.FirstOrDefault(u => u.UsuarioId == id);
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(Usuario user)
        {
            _context.Update(user);
            _context.SaveChanges();
        }
    }
}
