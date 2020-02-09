using System.Linq;
using System.Linq.Dynamic;

namespace BusinessLayer
{
    public class SortingService
    {
        public static string SortByAscending = "ASC";
        public static string SortByDescending = "DESC";

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
