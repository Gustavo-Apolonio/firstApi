using System;

namespace api.Source.Domains.Response
{
    public class FilmeResponse
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Genero { get; set; }
        public int Duracao { get; set; }
        public int Avaliacao { get; set; }
        public bool Disponivel { get; set; }
        public DateTime Lancamento { get; set; }
    }
}
