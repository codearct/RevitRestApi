using Business.ViewModel.AreaVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAreaService
    {
        List<AreaViewModel> GetAll();
        AreaViewModel GetByNumber(int areaNumber);
    }
}
