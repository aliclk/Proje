﻿using Proje.Core.DataAccess;
using Proje.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proje.Northwind.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        //Product ile ilgili custom operations
    }
}