using AutoMapper;
using AutoMapperProject.Dtos;
using AutoMapperProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperProject.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class LivroController : ControllerBase
	{
		public List<LivroModel> livros = new List<LivroModel>
		{
			new LivroModel {
				Id = 1,
				Ttulo = "DDD",
				Autor = "Eric Evans",
				Isbn = "abc-265",
				DataCadastro = new DateTime(2024,06,01)

			},

			new LivroModel {
				Id = 2,
				Ttulo = "LLL",
				Autor = "Felix Terrick",
				Isbn = "abc-658",
				DataCadastro = new DateTime(2024,06,15)

			},

			new LivroModel {
				Id = 3,
				Ttulo = "AAA",
				Autor = "Jack Bauer",
				Isbn = "abc-265",
				DataCadastro = new DateTime(2024,05,30)

			},

			new LivroModel {
				Id = 4,
				Ttulo = "zzz",
				Autor = "John ",
				Isbn = "abc-859",
				DataCadastro = new DateTime(2024,06,09)

			}
		};


		private readonly IMapper _mapper;
        public LivroController(IMapper mapper)
        {
			_mapper = mapper;
        }

        [HttpGet("BuscaLivroSemAutoMapper")]
		public ActionResult<List<LivroModel>>BuscaLivrosSemMapper()
		{
			return Ok(livros);
		}

		[HttpGet("BuscaLivrosComMapper")]
		public ActionResult<List<LivroModel>> BuscaLivrosComMapper()
		{
			var LivrosDto = _mapper.Map<List<LivroDto>>(livros);



			return Ok(LivrosDto);
		}

		[HttpPost("CriarLivros")]
		public ActionResult<List<LivroModel>> CriarLivros(LivroCadastroDto livro)
		{

			var livroModel = _mapper.Map<LivroModel>(livro);

			livroModel.Id = livros.Last().Id + 1;

			livros.Add(livroModel);
			


			return Ok(livro);
		}

	}
}
