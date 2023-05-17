using AutoMapper;
using CityGuideAPIV1.Dtos;
using CityGuideAPIV1.Models;

namespace CityGuideAPIV1.Helpers
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<City, CityForListDto>()
                .ForMember(dest=> dest.PhotoUrl, opt=> { opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url); });

            CreateMap<City, CityForDetailDto>();
            CreateMap<PhotoForCreationDto, Photo>();
            CreateMap<Photo, PhotoForReturnDto>();
        }
    }
}
