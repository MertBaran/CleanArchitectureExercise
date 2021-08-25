using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //Dal: data access layer
    public interface IProductDal : IEntityRepository<Product>     
    {
      
    }
}
