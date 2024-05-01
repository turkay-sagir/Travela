using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travela.BusinessLayer.Abstract;
using Travela.DataAccessLayer.Abstract;
using Travela.EntityLayer.Concrete;

namespace Travela.BusinessLayer.Concrete
{
    public class DestinationManager : IDestinationService
    {
        private readonly IDestinationDal _destionationDal;

        public DestinationManager(IDestinationDal destionationDal)
        {
            _destionationDal = destionationDal;
        }

        public void TDelete(int id)
        {
            _destionationDal.Delete(id);
        }

        public Destination TGetById(int id)
        {
            return _destionationDal.GetById(id);
        }

        public List<Destination> TGetListAll()
        {
            return _destionationDal.GetListAll();
        }

        public void TInsert(Destination entity)
        {
            _destionationDal.Insert(entity);
        }

        public void TUpdate(Destination entity)
        {
            _destionationDal.Update(entity);
        }
    }
}
