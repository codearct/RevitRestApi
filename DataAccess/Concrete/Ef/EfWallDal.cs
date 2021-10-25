using Core.DataAccess.Ef;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Ef
{
    public class EfWallDal : EfEntityRepositoryBase<Wall, RevitSampleProjectDBContext>, IWallDal
    {
        public ICollection<Wall> GetAll()
        {
            using (RevitSampleProjectDBContext context=new RevitSampleProjectDBContext())
            {
                var walls = context.Walls
                    .Include(w => w.Type)
                    .Include(w => w.PhaseCreatedNavigation)
                    .Include(w => w.PhaseDemolishedNavigation)
                    .Include(w => w.DesignOptionNavigation)
                    .Include(w => w.StructuralUsageNavigation)
                    .Include(w => w.BaseConstraintNavigation)
                    .Include(w => w.TopConstraintNavigation)
                    .Include(w => w.CaseworkOnWalls)
                    .Include(w => w.CurtainWallPanelOnWalls)
                    .Include(w => w.DoorWalls)
                    .Include(w => w.GenericModelOnWalls)
                    .Include(w => w.LightingFixtureOnWalls)
                    .Include(w => w.MechanicalEquipmentOnWalls)
                    .Include(w => w.OpeningOnWalls)
                    .Include(w => w.PlumbingFixtureOnWalls)
                    .Include(w => w.RebarOnWalls)
                    .Include(w => w.WindowWalls)
                    .OrderBy(w => w.Id)
                    .ToList();

                return walls;
            }
        }

        public ICollection<Wall> GetByType(string wallType)
        {
            using (RevitSampleProjectDBContext context = new RevitSampleProjectDBContext())
            {
                var walls = context.Walls
                    .Include(w=>w.Type)
                    .Include(w => w.PhaseCreatedNavigation)
                    .Include(w => w.PhaseDemolishedNavigation)
                    .Include(w => w.DesignOptionNavigation)
                    .Include(w => w.StructuralUsageNavigation)
                    .Include(w => w.BaseConstraintNavigation)
                    .Include(w => w.TopConstraintNavigation)
                    .Include(w => w.CaseworkOnWalls)
                    .Include(w => w.CurtainWallPanelOnWalls)
                    .Include(w => w.DoorWalls)
                    .Include(w => w.GenericModelOnWalls)
                    .Include(w => w.LightingFixtureOnWalls)
                    .Include(w => w.MechanicalEquipmentOnWalls)
                    .Include(w => w.OpeningOnWalls)
                    .Include(w => w.PlumbingFixtureOnWalls)
                    .Include(w => w.RebarOnWalls)
                    .Include(w => w.WindowWalls)
                    .Where(w => w.Type.TypeName == wallType)
                    .ToList();

                return walls;
            }
        }
    }
}
