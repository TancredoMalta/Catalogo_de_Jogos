using System;

namespace MaltaCatalogoJogos.ViewModel
{
    public class JogoViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Produtora { get; set; }
        public double Preco { get; set; }
        public string genero { get; set; }
        public int lançamento { get; set; }
        public int classificacao { get; set; }
    }
}