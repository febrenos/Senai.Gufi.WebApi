using Senai.Gufi.WebApi.Domains;
using Senai.Gufi.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gufi.WebApi.Repositories
{
    public class EventoRepository : IEventoRepository
    {
        GufiContext ctx = new GufiContext();

        public void Atualizar(int id, Evento eventoAtualizado)
        {
            Evento eventoBuscado = ctx.Evento.Find(id);

            eventoBuscado.NomeEvento = eventoAtualizado.NomeEvento;

            eventoBuscado.DataEvento = eventoAtualizado.DataEvento;

            eventoBuscado.Descricao = eventoAtualizado.Descricao;

            eventoBuscado.AcessoLivre = eventoAtualizado.AcessoLivre;

            eventoBuscado.IdInstituicao = eventoAtualizado.IdInstituicao;

            eventoBuscado.IdTipoEvento = eventoAtualizado.IdTipoEvento;

            eventoBuscado.IdInstituicaoNavigation = eventoAtualizado.IdInstituicaoNavigation;

            eventoBuscado.IdTipoEventoNavigation = eventoAtualizado.IdTipoEventoNavigation;

            eventoBuscado.Presenca = eventoAtualizado.Presenca;

            ctx.Evento.Update(eventoAtualizado);

            ctx.SaveChanges();
        }

        public Evento BuscarPorId(int id)
        {
            return ctx.Evento.Find(id);
        }

        public void Cadastrar(Evento novoEvento)
        {
            ctx.Evento.Add(novoEvento);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            ctx.Evento.Remove(BuscarPorId(id));

            ctx.SaveChanges();
        }

        public List<Evento> Listar()
        {
            return ctx.Evento.ToList();
        }
    }
}
