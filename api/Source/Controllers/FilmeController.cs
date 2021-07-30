using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace api.Source.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        Service.FilmeService srv = new Service.FilmeService();
        Utils.FilmeConvertor cnv = new Utils.FilmeConvertor();

        [HttpPost("adicionar")]
        public async Task<ActionResult<Domains.Response.FilmeResponse>> AdicionarFilme(Domains.Request.FilmeRequest req)
        {
            try
            {
                Models.TbFilme table = cnv.ToTable(req);

                table = await srv.AdicionarFilme(table);

                if (table == null) return NotFound(new Domains.Response.ErrorResponse(404, "Filme não inserido."));

                Domains.Response.FilmeResponse resp = cnv.ToResponse(table);

                return resp;
            }
            catch (Exception e)
            {
                return BadRequest(
                    new Domains.Response.ErrorResponse(400, e.Message)
                );
            }
        }

        [HttpGet("consultar")]
        public async Task<ActionResult<List<Domains.Response.FilmeResponse>>> ConsultarFilmes()
        {
            try
            {
                List<Models.TbFilme> tables = await srv.ConsultarFilmes();

                if (tables == null) return NotFound(new Domains.Response.ErrorResponse(404, "Não há filmes registrados."));

                List<Domains.Response.FilmeResponse> resp = cnv.ToResponse(tables);

                return resp;
            }
            catch (Exception e)
            {
                return BadRequest(
                    new Domains.Response.ErrorResponse(400, e.Message)
                );
            }
        }

        [HttpPut("alterar/{idFilme}")]
        public async Task<ActionResult<Domains.Response.FilmeResponse>> AlterarFilme(int idFilme, Domains.Request.FilmeRequest req)
        {
            try
            {
                Models.TbFilme thisTable = await srv.ConsultarFilme(idFilme);

                if (thisTable == null) return NotFound(new Domains.Response.ErrorResponse(404, "Filme não registrado."));

                Models.TbFilme newTable = cnv.ToTable(req);

                thisTable = await srv.AlterarFilme(thisTable, newTable);

                Domains.Response.FilmeResponse resp = cnv.ToResponse(thisTable);

                return resp;
            }
            catch (Exception e)
            {
                return BadRequest(
                    new Domains.Response.ErrorResponse(400, e.Message)
                );
            }
        }

        [HttpDelete("deletar/{idFilme}")]
        public async Task<ActionResult<Domains.Response.FilmeResponse>> DeletarFilme(int idFilme)
        {
            try
            {
                Models.TbFilme table = await srv.ConsultarFilme(idFilme);

                if (table == null) return NotFound(new Domains.Response.ErrorResponse(404, "Filme não registrado."));

                table = await srv.DeletarFilme(table);

                Domains.Response.FilmeResponse resp = cnv.ToResponse(table);

                return resp;
            }
            catch (Exception e)
            {
                return BadRequest(
                    new Domains.Response.ErrorResponse(400, e.Message)
                );
            }
        }
    }
}
