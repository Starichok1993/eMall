using eMall.Domain.Entities;
using eMall.Infrastructure.Mapping.Base;

namespace eMall.Infrastructure.Mapping
{
    public class ProductMap : EntityMap<Product>
    {
        protected override string TableName => "product";
    }
}
