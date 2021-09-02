using System;
using System.Linq;
using API.Resources;
using API.Entities;
using API.Extensions;
using AutoMapper;

namespace API.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AppUser, MemberResource>()
                .ForMember(dest => dest.PhotoUrl, opt => opt.MapFrom(src =>
                    src.Photos.FirstOrDefault(x => x.IsMain).Url))
                .ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.DateOfBirth.CalculateAge()));
            CreateMap<Photo, PhotoResource>();
            CreateMap<ProfileUpdateResource, AppUser>();
            CreateMap<RegisterResource, AppUser>();
            CreateMap<Message, MessageResource>()
                .ForMember(dest => dest.SenderPhotoUrl, opt => opt.MapFrom(src =>
                    src.Sender.Photos.FirstOrDefault(x => x.IsMain).Url))
                .ForMember(dest => dest.RecipentPhotoUrl, opt => opt.MapFrom(src =>
                    src.Recipent.Photos.FirstOrDefault(x => x.IsMain).Url));

        }
    }
}