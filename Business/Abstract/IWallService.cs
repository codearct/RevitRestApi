using Business.ViewModel.Wall;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IWallService
    {
        IDataResult<List<WallViewModel>> GetAll();
        IDataResult<WallViewModel> GetById(int id);
    }
}
