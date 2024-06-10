using AutoMapper;
using AutoMapperProject.Dtos;
using AutoMapperProject.Models;

namespace AutoMapperProject.Profiles
{
	public class AutoMapperProfiles : Profile
	{
        public AutoMapperProfiles()
        {
            CreateMap<LivroModel, LivroDto>();
			CreateMap< LivroCadastroDto, LivroModel>();
		}
    }	
}
