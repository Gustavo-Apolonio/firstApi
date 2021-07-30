using System.Collections.Generic;

namespace api.Source.Utils
{
    public class FilmeConvertor
    {
        public Models.TbFilme ToTable(Domains.Request.FilmeRequest req)
        {
            Models.TbFilme resp = new Models.TbFilme();

            resp.NmFilme = req.Nome;
            resp.DsGenero = req.Genero;
            resp.NrDuracao = req.Duracao;
            resp.VlAvaliacao = req.Avaliacao;
            resp.BtDisponivel = req.Disponivel;
            resp.DtLancamento = req.Lancamento;

            return resp;
        }

        public Domains.Response.FilmeResponse ToResponse(Models.TbFilme req)
        {
            Domains.Response.FilmeResponse resp = new Domains.Response.FilmeResponse();

            resp.ID = req.IdFilme;
            resp.Nome = req.NmFilme;
            resp.Genero = req.DsGenero;
            resp.Duracao = req.NrDuracao;
            resp.Avaliacao = req.VlAvaliacao;
            resp.Disponivel = req.BtDisponivel;
            resp.Lancamento = req.DtLancamento;

            return resp;
        }

        public List<Domains.Response.FilmeResponse> ToResponse(List<Models.TbFilme> reqs)
        {
            List<Domains.Response.FilmeResponse> resp = new List<Domains.Response.FilmeResponse>();

            foreach (Models.TbFilme filme in reqs)
            {
                Domains.Response.FilmeResponse response = this.ToResponse(filme);
                resp.Add(response);
            }

            return resp;
        }
    }
}
