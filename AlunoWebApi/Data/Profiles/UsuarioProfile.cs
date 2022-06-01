using AlunoWebApi.Model;
using AlunoWebApi.Model.Dto;
using AutoMapper;
namespace AlunoWebApi.Data.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<Usuario, UsuarioDto>();
            CreateMap<UsuarioDto, Usuario>();
        }
    }
}
