using DataAccessLayer.Context;
using System.Collections.Generic;
using System.Linq;

namespace Repositories.Repositories
{
    public class CostCenterRepository
    {
        private readonly HrmsEntities _dbContext;

        public CostCenterRepository()
        {
            _dbContext = new HrmsEntities();
        }

        public IQueryable<Model.CostCenter> GetCostCenters()
        {
            return _dbContext.CostCenters
                .Where(x => x.RecordStatus == true)
                .Select(x => new Model.CostCenter
                {
                    Description = x.Description,
                    Id = x.Id,
                    Name = x.Name
                });
        }

        public Model.CostCenter SaveCostCenter(Model.CostCenter costCenter)
        {
            CostCenter costCenterToSave = new CostCenter
            {
                Description = costCenter.Description,
                Name = costCenter.Name
            };

            _dbContext.CostCenters.Add(costCenterToSave);
            _dbContext.SaveChanges();

            costCenter.Id = costCenterToSave.Id;
            return costCenter;
        }

        public Model.CostCenter UpdateCostCenter(Model.CostCenter costCenter)
        {
            var costCenterToUpdate = _dbContext.CostCenters
                .FirstOrDefault(x => x.Id == costCenter.Id.GetValueOrDefault() && x.RecordStatus == true);

            costCenterToUpdate.Description = costCenter.Description;
            costCenterToUpdate.Name = costCenter.Name;

            _dbContext.SaveChanges();

            return costCenter;
        }

        public Model.CostCenter DeleteCostCenter(long id)
        {
            var costCenterToDelete = _dbContext.CostCenters
                .FirstOrDefault(x => x.Id == id);
            costCenterToDelete.RecordStatus = false;

            _dbContext.SaveChanges();

            return new Model.CostCenter
            {
                Description = costCenterToDelete.Description,
                Id = costCenterToDelete.Id,
                Name = costCenterToDelete.Name
            };
        }

        public List<long> DeleteCostCenters(List<long> ids)
        {
            var costCentersToDelete = _dbContext.CostCenters
                .Where(x => ids.Contains(x.Id))
                .ToList();
            costCentersToDelete.ForEach(x => x.RecordStatus = false);

            _dbContext.SaveChanges();

            return ids;
        }
    }
}
