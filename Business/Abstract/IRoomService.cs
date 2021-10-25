using Business.ViewModel.RoomVM;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRoomService
    {
        IDataResult<List<RoomViewModel>> GetAll();
        IDataResult<RoomViewModel> GetByNumber(int roomNumber);
    }
}
