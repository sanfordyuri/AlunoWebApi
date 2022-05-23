using AlunoWebApi.Model;
using AlunoWebApi.Model.Dto;
using AutoMapper;

namespace AlunoWebApi.Data.Profiles
{
    public class AlunoProfile : Profile
    {

        public AlunoProfile()
        {
            CreateMap<Aluno, AlunoDto>();
            CreateMap<AlunoDto, Aluno>();
        }

    }
}
