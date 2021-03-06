using AutoMapper;
using Business.Abstract;
using Business.Constants;
using Business.ViewModel.AreaVM;
using Core.Utilities.Results;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AreaManager:IAreaService
    {
        private readonly IMapper _mapper;
        private readonly IAreaDal _areaDal;
        public AreaManager(IMapper mapper, IAreaDal areaDal)
        {
            _mapper = mapper;
            _areaDal = areaDal;
        }

        public IDataResult<List<AreaViewModel>> GetAll()
        {
            var areas = _areaDal.GetAll();

            List<AreaViewModel> areaVMs = _mapper.Map<List<AreaViewModel>>(areas);

            return new SuccessDataResult<List<AreaViewModel>>(areaVMs);
        }

        public IDataResult<AreaViewModel> GetById(int id)
        {
            var area = _areaDal.GetById(id);
            if (area is null)
            {
                return new ErrorDataResult<AreaViewModel>(Messages.AreaNotExist);
            }

            AreaViewModel areaVM = _mapper.Map<AreaViewModel>(area);

            return new SuccessDataResult<AreaViewModel>(areaVM);
        }
    }
}
