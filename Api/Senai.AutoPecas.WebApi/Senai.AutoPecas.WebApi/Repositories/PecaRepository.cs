using Microsoft.EntityFrameworkCore;
using Senai.AutoPecas.WebApi.Domains;
using Senai.AutoPecas.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.AutoPecas.WebApi.Repositories
{
    public class PecaRepository : IPecaRepository
    {
       
        public List<Pecas> Listar()
        {
            using (AutoPecasContext ctx = new AutoPecasContext())
            {
                return ctx.Pecas.Include(x => x.IdFornecedorNavigation).ToList();
            }
        }

 

        public Pecas BuscarPorId(int id)
        {
            using (AutoPecasContext ctx = new AutoPecasContext())
            {
                return ctx.Pecas.FirstOrDefault(x => x.IdPeca == id);
            }
        }

        public void Cadastrar(Pecas peca)
        {
            using (AutoPecasContext ctx = new AutoPecasContext())
            {
                ctx.Pecas.Add(peca);
                ctx.SaveChanges();
            }
        }

        public void Deletar(int id)
        {
            using (AutoPecasContext ctx = new AutoPecasContext())
            {
                Pecas Peca = ctx.Pecas.Find(id);
                ctx.Pecas.Remove(Peca);
                ctx.SaveChanges();
            }
        }

        public void Atualizar(Pecas peca)
        {
            using (AutoPecasContext ctx = new AutoPecasContext())
            {
                Pecas PecaRetornada = ctx.Pecas.FirstOrDefault(x => x.IdPeca == peca.IdPeca);
                PecaRetornada.CodigoDaPeca = peca.CodigoDaPeca;
                PecaRetornada.Descricao = peca.Descricao;
                PecaRetornada.Peso = peca.Peso;
                PecaRetornada.PreçoDoCusto = peca.PreçoDoCusto;
                PecaRetornada.PreçoDaVenda = peca.PreçoDaVenda;
                PecaRetornada.IdFornecedor = peca.IdFornecedor;
                ctx.Pecas.Update(PecaRetornada);
                ctx.SaveChanges();
            }
        }
    }
}
