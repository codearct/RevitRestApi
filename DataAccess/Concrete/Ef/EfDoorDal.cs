using Core.DataAccess.Ef;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Ef
{
    public class EfDoorDal : EfEntityRepositoryBase<Door, RevitSampleProjectDBContext>, IDoorDal
    {
        public ICollection<Door> GetAll()
        {
            using (RevitSampleProjectDBContext context =new RevitSampleProjectDBContext())
            {
                var doors = context.Doors
                    .Include(d => d.Type)
                    .Include(d => d.LevelNavigation)
                    .Include(d => d.DoorWall)
                        .ThenInclude(dw => dw.Wall)
                    .Include(d => d.DesignOptionNavigation)
                    .Include(d => d.PhaseCreatedNavigation)
                    .Include(d => d.PhaseDemolishedNavigation)
                    .OrderBy(d => d.Id)
                    .ToList();

                return doors;
            }
        }

        public Door GetById(int id)
        {
            using (RevitSampleProjectDBContext context = new RevitSampleProjectDBContext())
            {
                var door = context.Doors
                    .Include(d => d.Type)
                    .Include(d => d.LevelNavigation)
                    .Include(d => d.DoorWall)
                        .ThenInclude(dw => dw.Wall)
                    .Include(d => d.DesignOptionNavigation)
                    .Include(d => d.PhaseCreatedNavigation)
                    .Include(d => d.PhaseDemolishedNavigation)
                    .SingleOrDefault(d => d.Id == id);

                return door;
            }
        }
    }
}
