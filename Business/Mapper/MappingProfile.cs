using AutoMapper;
using Business.ViewModel.AreaVM;
using Business.ViewModel.RoomVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Mapper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Entities.Concrete.Room, RoomViewModel>()
                .ForMember(dest => dest.DesignOption, opt => opt.MapFrom(src => src.DesignOptionNavigation.Name))
                .ForMember(dest => dest.Phase, opt => opt.MapFrom(src => src.Phase.Name))
                .ForMember(dest => dest.Level, opt => opt.MapFrom(src => src.LevelNavigation.Name))
                .ForMember(dest => dest.RoomAssociations, opt => opt.MapFrom(src => src.RoomAssociations.Select(ra => ra.Phase.Name).Distinct().ToList()))
                .ForMember(dest => dest.ToRoomAssociations, opt => opt.MapFrom(src => src.RoomFromToAssociationFromRoomNavigations
                    .Select(ra => "To " + ra.ToRoomNavigation.Number + "-" + ra.ToRoomNavigation.Name).ToList()))
                .ForMember(dest => dest.FromRoomAssociations, opt => opt.MapFrom(src => src.RoomFromToAssociationToRoomNavigations
                    .Select(ra => "From " + ra.FromRoomNavigation.Number + "-" + ra.FromRoomNavigation.Name).ToList()))
                .ForMember(dest => dest.Area, opt => opt.MapFrom(src => Math.Round(Convert.ToDecimal(src.Area), 2)))
                .ForMember(dest => dest.Perimeter, opt => opt.MapFrom(src => Math.Round(Convert.ToDecimal(src.Perimeter), 2)))
                .ForMember(dest => dest.Volume, opt => opt.MapFrom(src => Math.Round(Convert.ToDecimal(src.Volume), 2)))
                .ForMember(dest => dest.UnboundedHeight, opt => opt.MapFrom(src => Math.Round(Convert.ToDecimal(src.UnboundedHeight), 2)));

            CreateMap<Entities.Concrete.Area, AreaViewModel>()
                .ForMember(dest => dest.Level, opt => opt.MapFrom(src => src.LevelNavigation.Name))
                .ForMember(dest => dest.Area, opt => opt.MapFrom(src => Math.Round(Convert.ToDecimal(src.Area1), 2)))
                .ForMember(dest => dest.Perimeter, opt => opt.MapFrom(src => Math.Round(Convert.ToDecimal(src.Perimeter), 2)));


        }
    }
}
