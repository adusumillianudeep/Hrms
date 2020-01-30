using Model;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BusinessLayer.Mappers
{
    public class CostCenterMapper
    {
        public List<CostCenter> Map(DataSet dataSet)
        {
            return dataSet.Tables[0].AsEnumerable()
                .Select(row => new CostCenter
                {
                    Id = row.Field<long>("Id"),
                    Name = row.Field<string>("Name"),
                    Description = row.Field<string>("Description")
                })
                .ToList();
        }
    }
}
