using Business.ViewModel.DoorVM;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IDoorService
    {
        IDataResult<List<DoorViewModel>> GetAll();
        IDataResult<DoorViewModel> GetById(int id);
    }
}
