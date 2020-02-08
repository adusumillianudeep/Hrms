using System.Linq;
using System.Linq.Dynamic;

namespace BusinessLayer
{
    public class SortingService
    {
        public IQueryable<T> Sort<T>(IQueryable<T> list, string sortField, string sortOrder)
        {
            var sortedList = list;

            if (!string.IsNullOrWhiteSpace(sortField))
            {
                sortedList = list.OrderBy(sortField + " " + sortOrder);
            }

            return sortedList;
        }
    }
}
