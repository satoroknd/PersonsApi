using App.Common.Classes.Contracts;
using App.Common.Classes.DTO;
using App.Infraestructure.Database.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Config.Dependencies
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserEntity, UserContract>()
            .ForMember(dest => dest.UserID, opt => opt.MapFrom(src => src.UserID))
            .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.UserName))
            .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.Password))
            .ForMember(dest => dest.CreationDate, opt => opt.MapFrom(src => src.CreationDate))
            .ReverseMap();

            CreateMap<PersonEntity, PersonContract>()
            .ForMember(dest => dest.PersonID, opt => opt.MapFrom(src => src.PersonID))
            .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
            .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
            .ForMember(dest => dest.DNI, opt => opt.MapFrom(src => src.DNI))
            .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
            .ForMember(dest => dest.DocumentTypeID, opt => opt.MapFrom(src => src.DocumentTypeID))
            .ForMember(dest => dest.CreationDate, opt => opt.MapFrom(src => src.CreationDate))
            .ForMember(dest => dest.PersonCode, opt => opt.MapFrom(src => src.PersonCode))
            .ForMember(dest => dest.CompleteName, opt => opt.MapFrom(src => src.CompleteName))
            .ReverseMap();

            CreateMap<DocumentTypeEntity, DocumentTypeContract>()
            .ForMember(dest => dest.DocumentTypeID, opt => opt.MapFrom(src => src.DocumentTypeID))
            .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
            .ForMember(dest => dest.Code, opt => opt.MapFrom(src => src.Code))
            .ReverseMap();

            CreateMap<RegisterDTO, UserContract>()
             .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.Email))
             .ReverseMap();

            CreateMap<RegisterDTO, PersonContract>()
            .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
            .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
            .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
            .ForMember(dest => dest.DNI, opt => opt.MapFrom(src => src.DNI))
            .ForMember(dest => dest.DocumentTypeID, opt => opt.MapFrom(src => src.DocumentTypeID))
            .ReverseMap();

        }
    }
}
