using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs
{
    public class PagedContentBase
    {
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }
        public int PageSize { get; set; }
        public int RowCount { get; set; }

        public int FirstRowOnPage
        {

            get { return (CurrentPage - 1) * PageSize + 1; }
        }

        public int LastRowOnPage
        {
            get { return Math.Min(CurrentPage * PageSize, RowCount); }
        }
    }

    public class PagedContent<T> : PagedContentBase
    {
        public IList<T> Results { get; set; }

        public PagedContent()
        {
            Results = new List<T>();
        }
    }
}
