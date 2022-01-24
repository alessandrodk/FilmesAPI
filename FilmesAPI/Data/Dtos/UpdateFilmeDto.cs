using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data
{
    public class UpdateFilmeDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O Campo Titulo é obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo Direto é obrigatório")]
        public string Diretor { get; set; }
        public string Genero { get; set; }
        [Range(1, 600, ErrorMessage = "A duração deve ter no minimo 1 e no maximo 600 minutos")]
        public int Duracao { get; set; }
    }
}
