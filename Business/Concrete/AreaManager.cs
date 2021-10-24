using AutoMapper;
using Business.Abstract;
using Business.ViewModel.AreaVM;
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

        public List<AreaViewModel> GetAll()
        {
            var areas = _areaDal.GetAll();
            List<AreaViewModel> areaVMs = _mapper.Map<List<AreaViewModel>>(areas);
            return areaVMs;
        }

        public AreaViewModel GetByNumber(int areaNumber)
        {
            var area = _areaDal.GetByNumber(areaNumber);
            AreaViewModel areaVM = _mapper.Map<AreaViewModel>(area);
            return areaVM;
        }
    }
}
