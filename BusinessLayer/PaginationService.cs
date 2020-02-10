using System.Linq;

namespace BusinessLayer
{
    public class PaginationService
    {
        public IQueryable<T> ApplyPaging<T>(IQueryable<T> list, int pageNumber, int itemsPerPage)
        {
            return list.Skip((pageNumber - 1) * itemsPerPage).Take(itemsPerPage);
        }
    }
}
