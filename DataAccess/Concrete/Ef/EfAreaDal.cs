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
    public class EfAreaDal : EfEntityRepositoryBase<Area, RevitSampleProjectDBContext>, IAreaDal
    {
        public ICollection<Area> GetAll()
        {
            using (RevitSampleProjectDBContext context = new RevitSampleProjectDBContext())
            {
                var areas = context.Areas
                    .Include(a => a.LevelNavigation)
                    .OrderBy(a => a.Id)
                    .ToList();

                return areas;
            }
        }

        public Area GetById(int id)
        {
            using (RevitSampleProjectDBContext context = new RevitSampleProjectDBContext())
            {
                var area = context.Areas
                    .Include(a => a.LevelNavigation)
                    .SingleOrDefault(a => a.Id==id);

                return area;
            }
        }
    }
}
