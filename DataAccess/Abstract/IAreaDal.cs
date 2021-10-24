using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IAreaDal
    {
        ICollection<Area> GetAll();
        Area GetByNumber(int areaNumber);
    }
}
