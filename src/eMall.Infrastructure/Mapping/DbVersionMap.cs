using eMall.Domain.Entities;
using eMall.Infrastructure.Mapping.Base;

namespace eMall.Infrastructure.Mapping
{
    public class DbVersionMap : EntityMap<DbVersion>
    {
        protected override string TableName => "db_version";
    }
}