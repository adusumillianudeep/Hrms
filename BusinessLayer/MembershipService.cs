using Model;
using Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer
{
    public class MembershipService
    {
        private readonly MembershipRepository _membershipRepository;
        private readonly SortingService _sortingService;
        private readonly PaginationService _paginationService;

        public MembershipService()
        {
            _membershipRepository = new MembershipRepository();
            _sortingService = new SortingService();
            _paginationService = new PaginationService();
        }

        public List<MembershipModel> GetMemberships()
        {
            try
            {
                return _membershipRepository.GetMemberships()
                                .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<MembershipModel> GetMembershipsForPage(int pageNumber, int itemsPerPage, string sortField, string sortOrder)
        {
            try
            {
                var sortedMemberships = _sortingService.Sort(_membershipRepository.GetMemberships(), sortField, sortOrder);

                return _paginationService.ApplyPaging(sortedMemberships, pageNumber, itemsPerPage)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public MembershipModel GetMembership(long membershipId)
        {
            try
            {
                return _membershipRepository.GetMemberships()
                    .FirstOrDefault(x => x.Id == membershipId);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public MembershipModel SaveMembership(MembershipModel membership)
        {
            try
            {
                return _membershipRepository.SaveMembership(membership);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public MembershipModel UpdateMembership(MembershipModel membership)
        {
            try
            {
                return _membershipRepository.UpdateMembership(membership);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public MembershipModel DeleteMembership(long membershipId)
        {
            try
            {
                return _membershipRepository.DeleteMembership(membershipId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<long> DeleteMemberships(List<long> membershipIds)
        {
            try
            {
                return _membershipRepository.DeleteMemberships(membershipIds);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
