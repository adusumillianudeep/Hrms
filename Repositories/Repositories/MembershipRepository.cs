using DataAccessLayer.Context;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositories.Repositories
{
    public class MembershipRepository
    {
        private readonly HrmsEntities _dbContext;

        public MembershipRepository()
        {
            _dbContext = new HrmsEntities();
        }

        public IQueryable<MembershipModel> GetMemberships()
        {
            return _dbContext.Memberships
                .Where(x => x.RecordStatus == true)
                .Select(x => new MembershipModel
                {
                    Id = x.Id,
                    Name = x.Name
                });
        }

        public MembershipModel SaveMembership(MembershipModel membershipModel)
        {
            var membership = new Membership
            {
                Name = membershipModel.Name
            };

            _dbContext.Memberships.Add(membership);
            _dbContext.SaveChanges();

            membershipModel.Id = membership.Id;
            return membershipModel;
        }

        public MembershipModel UpdateMembership(MembershipModel membershipModel)
        {
            var membership = _dbContext.Memberships
                .FirstOrDefault(x => x.Id == membershipModel.Id && x.RecordStatus == true);

            membership.Name = membershipModel.Name;
            membership.UpdateDate = DateTime.Now;

            _dbContext.SaveChanges();

            return membershipModel;
        }

        public MembershipModel DeleteMembership(long membershipId)
        {
            var membership = _dbContext.Memberships
                .FirstOrDefault(x => x.Id == membershipId);

            membership.RecordStatus = false;
            membership.UpdateDate = DateTime.Now;

            _dbContext.SaveChanges();

            return new MembershipModel
            {
                Id = membership.Id,
                Name = membership.Name
            };
        }

        public List<long> DeleteMemberships(List<long> membershipId)
        {
            var membership = _dbContext.Memberships
                .Where(x => membershipId.Contains(x.Id))
                .ToList();

            membership.ForEach(x => x.RecordStatus = false);
            membership.ForEach(x => x.UpdateDate = DateTime.Now);

            _dbContext.SaveChanges();

            return membershipId;
        }
    }
}
