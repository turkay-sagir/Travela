﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travela.DataAccessLayer.Abstract;
using Travela.DataAccessLayer.Context;
using Travela.DataAccessLayer.Repository;
using Travela.EntityLayer.Concrete;

namespace Travela.DataAccessLayer.Concrete
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(TravelaContext context) : base(context)
        {

        }
    }
}