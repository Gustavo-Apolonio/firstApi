using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace api.Source.Database
{
    public class FilmeDatabase
    {
        Models.db_cinemaContext ctx = new Models.db_cinemaContext();

        public async Task<Models.TbFilme> AdicionarFilme(Models.TbFilme filme)
        {
            await ctx.TbFilmes.AddAsync(filme);
            await ctx.SaveChangesAsync();
            return filme;
        }

        public async Task<List<Models.TbFilme>> ConsultarFilmes()
        {
            List<Models.TbFilme> filmes = await ctx.TbFilmes.ToListAsync();
            return filmes;
        }

        public async Task<Models.TbFilme> ConsultarFilme(int idFilme)
        {
            Models.TbFilme filme = await ctx.TbFilmes.FirstOrDefaultAsync(filme => filme.IdFilme == idFilme);
            return filme;
        }

        public async Task<Models.TbFilme> AlterarFilme(Models.TbFilme filmeAtual, Models.TbFilme filmeNovo)
        {
            filmeAtual.NmFilme = filmeNovo.NmFilme;
            filmeAtual.DsGenero = filmeNovo.DsGenero;
            filmeAtual.NrDuracao = filmeNovo.NrDuracao;
            filmeAtual.VlAvaliacao = filmeNovo.VlAvaliacao;
            filmeAtual.BtDisponivel = filmeNovo.BtDisponivel;
            filmeAtual.DtLancamento = filmeNovo.DtLancamento;

            await ctx.SaveChangesAsync();

            return filmeAtual;
        }

        public async Task<Models.TbFilme> DeletarFilme(Models.TbFilme filme)
        {
            ctx.TbFilmes.Remove(filme);
            await ctx.SaveChangesAsync();

            return filme;
        }
    }
}
