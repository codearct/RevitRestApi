using AutoMapper;
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
                    .Select(ra => "From " + ra.FromRoomNavigation.Number+"-"+ ra.FromRoomNavigation.Name).ToList()));

        }
    }
}
