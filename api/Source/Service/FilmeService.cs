using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace api.Source.Service
{
    public class FilmeService
    {
        Database.FilmeDatabase db = new Database.FilmeDatabase();

        private void VerificarFilme(Models.TbFilme filme)
        {
            if (filme.NmFilme == String.Empty) throw new Exception("Nome do fime não pode ser vazio!");
            if (filme.DsGenero == String.Empty) throw new Exception("Gênero do filme não pode ser vazio!");
            if (filme.NrDuracao <= 0) throw new Exception("Duração do filme tem que ser maior que 0.");
            if (filme.VlAvaliacao < 0) throw new Exception("Avaliação do filme não pode ser negativo.");
            if (filme.BtDisponivel != false && filme.BtDisponivel != true) throw new Exception("Disponibildade do filme inválida.");
            if (filme.DtLancamento < DateTime.MinValue) throw new Exception("Data de lançamento não pode ser menor que 01/01/0001!");
            if (filme.DtLancamento > DateTime.MaxValue) throw new Exception("Data de lançamento não pode ser maior que 31/12/9999!");
        }

        private void VerificarId(int id)
        {
            if (id <= 0) throw new Exception("ID do filme inválido!");
        }

        public async Task<Models.TbFilme> AdicionarFilme(Models.TbFilme filme)
        {
            this.VerificarFilme(filme);

            filme = await db.AdicionarFilme(filme);
            return filme;
        }

        public async Task<List<Models.TbFilme>> ConsultarFilmes()
        {
            List<Models.TbFilme> filmes = await db.ConsultarFilmes();
            return filmes;
        }

        public async Task<Models.TbFilme> ConsultarFilme(int idFilme)
        {
            this.VerificarId(idFilme);

            Models.TbFilme filme = await db.ConsultarFilme(idFilme);
            return filme;
        }

        public async Task<Models.TbFilme> AlterarFilme(Models.TbFilme filmeAtual, Models.TbFilme filmeNovo)
        {
            this.VerificarFilme(filmeNovo);

            filmeAtual = await db.AlterarFilme(filmeAtual, filmeNovo);
            return filmeAtual;
        }

        public async Task<Models.TbFilme> DeletarFilme(Models.TbFilme filme)
        {
            filme = await db.DeletarFilme(filme);
            return filme;
        }
    }
}
