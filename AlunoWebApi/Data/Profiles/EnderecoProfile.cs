using AlunoWebApi.Model;
using AlunoWebApi.Model.Dto;
using AutoMapper;

namespace AlunoWebApi.Data.Profiles
{
    public class EnderecoProfile : Profile
    {

        public EnderecoProfile()
        {
            CreateMap<Endereco, EnderecoDto>();
            CreateMap<EnderecoDto, Endereco>();
        }

    }
}
