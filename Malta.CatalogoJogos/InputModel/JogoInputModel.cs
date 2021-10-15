using System.ComponentModel.DataAnnotations;

namespace MaltaCatalogoJogos.InputModel
{
    public class JogoInputModel
    {
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "O nome do jogo deve conter entre 3 e 50 caracteres")]
        public string Nome { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "O nome da produtora deve conter entre 3 e 50 caracteres")]
        public string Produtora { get; set; }
        [Required]
        [Range(1, 1000, ErrorMessage = "O preço deve ser de no mínimo 1 real e no máximo 1000 reais")]
        public double Preco { get; set; }
        [Required]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "O nome do gênero deve conter entre 3 e 25 caracteres")]
        public string Genero { get; set; }
        [Required]
        [StringLength(4, MinimumLength = 4, ErrorMessage = "O ano de lançamento deve ser no formato XXXX")]
        public string Lancamento { get; set; }
        [Required]
        [StringLength(3, MinimumLength = 1, ErrorMessage = "A classificação indicativa deve conter entre 1 e 3 caracteres")]
        public string Classificacao { get; set; }
    }
}