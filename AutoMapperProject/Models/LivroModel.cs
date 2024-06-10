namespace AutoMapperProject.Models
{
	public class LivroModel
	{
        public int Id { get; set; }
		public string Ttulo { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
		public string Isbn { get; set; } = string.Empty;
		public DateTime DataCadastro { get; set; } = DateTime.Now.Date;
    }
}
