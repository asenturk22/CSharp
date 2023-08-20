using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    // IProductDal = Interface Product Data Access Layer
    // NuGet : DataAccess sağ tıkla "Manage NuGet Pakages..."
    // Browse sekmesine geçin 
    // Arama çubuğuna : entityframeworkcore.sql 
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();
    }
}


// Code Refactoring - Kodun iyileştirilmesi