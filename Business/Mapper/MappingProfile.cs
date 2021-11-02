using AutoMapper;
using Business.ViewModel.AreaVM;
using Business.ViewModel.DoorVM;
using Business.ViewModel.RoomVM;
using Business.ViewModel.Wall;
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
                .ForMember(dest => dest.DesignOption, opt => opt.MapFrom(
                            src => src.DesignOptionNavigation.Name))

                .ForMember(dest => dest.Phase, opt => opt.MapFrom(
                            src => src.Phase.Name))

                .ForMember(dest => dest.Level, opt => opt.MapFrom(
                            src => src.LevelNavigation.Name))

                .ForMember(dest => dest.RoomAssociations, opt => opt.MapFrom(
                            src => src.RoomAssociations.Select(ra => ra.Phase.Name).Distinct().ToList()))

                .ForMember(dest => dest.ToRoomAssociations, opt => opt.MapFrom(
                            src => src.RoomFromToAssociationFromRoomNavigations
                                .Select(ra => "To " + ra.ToRoomNavigation.Number + "-" + ra.ToRoomNavigation.Name)
                                .ToList()))

                .ForMember(dest => dest.FromRoomAssociations, opt => opt.MapFrom(
                            src => src.RoomFromToAssociationToRoomNavigations
                                .Select(ra => "From " + ra.FromRoomNavigation.Number + "-" + ra.FromRoomNavigation.Name)
                                .ToList()))

                .ForMember(dest => dest.Area, opt => opt.MapFrom(
                            src => Math.Round(Convert.ToDecimal(src.Area), 2)))

                .ForMember(dest => dest.Perimeter, opt => opt.MapFrom(
                            src => Math.Round(Convert.ToDecimal(src.Perimeter), 2)))

                .ForMember(dest => dest.Volume, opt => opt.MapFrom(
                            src => Math.Round(Convert.ToDecimal(src.Volume), 2)))

                .ForMember(dest => dest.UnboundedHeight, opt => opt.MapFrom(
                            src => Math.Round(Convert.ToDecimal(src.UnboundedHeight), 2)));


            CreateMap<Entities.Concrete.Area, AreaViewModel>()
                .ForMember(dest => dest.Level, opt => opt.MapFrom(
                            src => src.LevelNavigation.Name))

                .ForMember(dest => dest.Area, opt => opt.MapFrom(
                            src => Math.Round(Convert.ToDecimal(src.Area1), 2)))

                .ForMember(dest => dest.Perimeter, opt => opt.MapFrom(
                            src => Math.Round(Convert.ToDecimal(src.Perimeter), 2)));


            CreateMap<Entities.Concrete.Wall, WallViewModel>()
                .ForMember(dest => dest.WallType, opt => opt.MapFrom(
                            src => src.Type.TypeName))

                .ForMember(dest => dest.PhaseCreated, opt => opt.MapFrom(
                            src => src.PhaseCreatedNavigation.Name))

                .ForMember(dest => dest.PhaseDemolished, opt => opt.MapFrom(
                            src => src.PhaseDemolishedNavigation.Name))

                .ForMember(dest => dest.DesignOption, opt => opt.MapFrom(
                            src => src.DesignOptionNavigation.Name))

                .ForMember(dest => dest.StructuralUsage, opt => opt.MapFrom(
                            src => src.StructuralUsageNavigation.Name))

                .ForMember(dest => dest.BaseConstraint, opt => opt.MapFrom(
                            src => src.BaseConstraintNavigation.Name))

                .ForMember(dest => dest.TopConstraint, opt => opt.MapFrom(
                            src => src.TopConstraintNavigation.Name))

                .ForMember(dest => dest.Area, opt => opt.MapFrom(
                            src => Math.Round(Convert.ToDecimal(src.Area), 2)))

                .ForMember(dest => dest.Length, opt => opt.MapFrom(
                            src => Math.Round(Convert.ToDecimal(src.Length), 2)))

                .ForMember(dest => dest.Volume, opt => opt.MapFrom(
                            src => Math.Round(Convert.ToDecimal(src.Volume), 2)))

                .ForMember(dest => dest.TopOffset, opt => opt.MapFrom(
                            src => Math.Round(Convert.ToDecimal(src.TopOffset), 2)))

                .ForMember(dest => dest.BaseOffset, opt => opt.MapFrom(
                            src => Math.Round(Convert.ToDecimal(src.BaseOffset), 2)))

                .ForMember(dest => dest.UnconnectedHeight, opt => opt.MapFrom(
                            src => Math.Round(Convert.ToDecimal(src.UnconnectedHeight), 2)))

                .ForMember(dest => dest.CaseworkOnWalls, opt => opt.MapFrom(
                            src => src.CaseworkOnWalls.Select(cwow => cwow.Name).ToList()))

                .ForMember(dest => dest.CurtainWallPanelOnWalls, opt => opt.MapFrom(
                            src => src.CurtainWallPanelOnWalls.Select(cwpow => cwpow.HostName).ToList()))

                .ForMember(dest => dest.DoorOnWalls, opt => opt.MapFrom(
                            src => src.DoorWalls.Select(dw => dw.DoorName).ToList()))

                .ForMember(dest => dest.GenericModelOnWalls, opt => opt.MapFrom(
                            src => src.GenericModelOnWalls.Select(gmow => gmow.Name).ToList()))

                .ForMember(dest => dest.LightingFixtureOnWalls, opt => opt.MapFrom(
                            src => src.LightingFixtureOnWalls.Select(lfow => lfow.Name).ToList()))

                .ForMember(dest => dest.MechanicalEquipmentOnWalls, opt => opt.MapFrom(
                            src => src.MechanicalEquipmentOnWalls.Select(meow => meow.Name).ToList()))

                .ForMember(dest => dest.OpeningOnWalls, opt => opt.MapFrom(
                            src => src.OpeningOnWalls.Select(oow => oow.Name).ToList()))

                .ForMember(dest => dest.PlumbingFixtureOnWalls, opt => opt.MapFrom(
                            src => src.PlumbingFixtureOnWalls.Select(pfow => pfow.Name).ToList()))

                .ForMember(dest => dest.RebarOnWalls, opt => opt.MapFrom(
                            src => src.RebarOnWalls.Select(row => row.Name).ToList()))

                .ForMember(dest => dest.WindowOnWalls, opt => opt.MapFrom(
                            src => src.WindowWalls.Select(ww => ww.WindowName).ToList()));

            CreateMap<Entities.Concrete.Door, DoorViewModel>()
                .ForMember(dest => dest.DoorType, opt => opt.MapFrom(
                            src => src.Type.FamilyName))
                .ForMember(dest => dest.Level, opt => opt.MapFrom(
                            src => src.LevelNavigation.Name))
                .ForMember(dest => dest.Wall, opt => opt.MapFrom(
                            src => src.DoorWall.WallName))
                .ForMember(dest => dest.DesignOption, opt => opt.MapFrom(
                            src => src.DesignOptionNavigation.Name))
                .ForMember(dest => dest.PhaseCreated, opt => opt.MapFrom(
                            src => src.PhaseCreatedNavigation.Name))
                .ForMember(dest => dest.PhaseDemolished, opt => opt.MapFrom(
                            src => src.PhaseDemolishedNavigation.Name));






        }
    }
}
