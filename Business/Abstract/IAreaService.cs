using Business.ViewModel.AreaVM;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAreaService
    {
        IDataResult<List<AreaViewModel>> GetAll();
        IDataResult<AreaViewModel> GetByNumber(int areaNumber);
    }
}
