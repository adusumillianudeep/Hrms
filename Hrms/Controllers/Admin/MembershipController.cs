using BusinessLayer;
using Model;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;

namespace Hrms.Controllers.Admin
{
    [RoutePrefix("api/memberships")]
    public class MembershipController : ApiController
    {
        private readonly MembershipService _membershipService;

        public MembershipController()
        {
            _membershipService = new MembershipService();
        }

        [HttpGet]
        [Route("")]
        [ResponseType(typeof(IEnumerable<MembershipModel>))]
        public IHttpActionResult GetMemberships()
        {
            try
            {
                return Ok(_membershipService.GetMemberships());
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        [Route("~/api/membershipsforpage")]
        [ResponseType(typeof(IEnumerable<MembershipModel>))]
        public IHttpActionResult GetMembershipsForPage(int pageNumber = 1, int itemsPerPage = 10, string sortField = "Id", string sortOrder = "DESC")
        {
            try
            {
                if (!(sortOrder == SortingService.SortByAscending || sortOrder == SortingService.SortByDescending))
                {
                    return BadRequest("Invalid sort order");
                }

                return Ok(_membershipService.GetMembershipsForPage(pageNumber, itemsPerPage, sortField, sortOrder));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpGet]
        [Route("{membershipId}")]
        [ResponseType(typeof(MembershipModel))]
        public IHttpActionResult GetMembership(long membershipId)
        {
            try
            {
                return Ok(_membershipService.GetMembership(membershipId));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("save")]
        [ResponseType(typeof(MembershipModel))]
        public IHttpActionResult SaveMembership(MembershipModel membership)
        {
            try
            {
                return Ok(_membershipService.SaveMembership(membership));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        [Route("update")]
        [ResponseType(typeof(MembershipModel))]
        public IHttpActionResult UpdateMembership(MembershipModel membership)
        {
            try
            {
                if (membership.Id == null || membership.Id <= 0)
                {
                    return BadRequest("Invalid membership id");
                }

                return Ok(_membershipService.UpdateMembership(membership));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        [Route("delete/{membershipId}")]
        [ResponseType(typeof(MembershipModel))]
        public IHttpActionResult DeleteMembership(long membershipId)
        {
            try
            {
                return Ok(_membershipService.DeleteMembership(membershipId));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("deletememberships")]
        [ResponseType(typeof(MembershipModel))]
        public IHttpActionResult DeleteMemberships(List<long> membershipIds)
        {
            try
            {
                return Ok(_membershipService.DeleteMemberships(membershipIds));
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
