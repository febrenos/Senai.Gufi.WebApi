using Senai.Gufi.WebApi.Domains;
using Senai.Gufi.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.WebApi.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        public void Atualizar(int id, TipoUsuario tipoEventoAtualizado)
        {
            throw new NotImplementedException();
        }
        public int IdTipoUsuario { get; set; }

        public string TituloTipoUsuario { get; set; }

        public ICollection<Usuario> Usuario { get; set; }



        public TipoUsuario BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(TipoUsuario novoTipoUsuario)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<TipoUsuario> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
