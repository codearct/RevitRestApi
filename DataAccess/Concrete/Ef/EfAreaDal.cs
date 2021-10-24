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

        public Area GetByNumber(int areaNumber)
        {
            using (RevitSampleProjectDBContext context = new RevitSampleProjectDBContext())
            {
                var area = context.Areas
                    .Include(a => a.LevelNavigation)
                    .SingleOrDefault(a => Convert.ToInt32(a.Number) == areaNumber);

                return area;
            }
        }
    }
}
