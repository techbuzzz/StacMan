// <auto-generated>
//     This file was generated by a T4 template.
//     Don't change it directly as your change would get overwritten. Instead, make changes
//     to the .tt file (i.e. the T4 template) and save it to regenerate this file.
// </auto-generated>

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StackExchange.StacMan
{
    public partial class StacManClient : ICommentMethods
    {
        /// <summary>
        /// Stack Exchange API Comments methods
        /// </summary>
        public ICommentMethods Comments
        {
            get { return this; }
        }

        Task<StacManResponse<Comment>> ICommentMethods.GetAll(string site, string filter = null, int? page = null, int? pagesize = null, DateTime? fromdate = null, DateTime? todate = null, Comments.Sort? sort = null, DateTime? mindate = null, DateTime? maxdate = null, int? min = null, int? max = null, Order? order = null)
        {
            var filterObj = ValidateAndGetFilter(filter);

            ValidateString(site, "site");
            ValidatePaging(page, pagesize);
            ValidateSortMinMax(sort, mindate: mindate, maxdate: maxdate, min: min, max: max);

            var ub = new ApiUrlBuilder("/comments", useHttps: false);

            ub.AddParameter("site", site);
            ub.AddParameter("filter", filter);
            ub.AddParameter("page", page);
            ub.AddParameter("pagesize", pagesize);
            ub.AddParameter("fromdate", fromdate);
            ub.AddParameter("todate", todate);
            ub.AddParameter("sort", sort);
            ub.AddParameter("min", mindate);
            ub.AddParameter("max", maxdate);
            ub.AddParameter("min", min);
            ub.AddParameter("max", max);
            ub.AddParameter("order", order);

            return CreateApiTask<Comment>(ub, filterObj, "/comments");
        }

        Task<StacManResponse<Comment>> ICommentMethods.GetByIds(string site, IEnumerable<int> ids, string filter = null, int? page = null, int? pagesize = null, DateTime? fromdate = null, DateTime? todate = null, Comments.Sort? sort = null, DateTime? mindate = null, DateTime? maxdate = null, int? min = null, int? max = null, Order? order = null)
        {
            var filterObj = ValidateAndGetFilter(filter);

            ValidateString(site, "site");
            ValidateEnumerable(ids, "ids");
            ValidatePaging(page, pagesize);
            ValidateSortMinMax(sort, mindate: mindate, maxdate: maxdate, min: min, max: max);

            var ub = new ApiUrlBuilder(String.Format("/comments/{0}", String.Join(";", ids)), useHttps: false);

            ub.AddParameter("site", site);
            ub.AddParameter("filter", filter);
            ub.AddParameter("page", page);
            ub.AddParameter("pagesize", pagesize);
            ub.AddParameter("fromdate", fromdate);
            ub.AddParameter("todate", todate);
            ub.AddParameter("sort", sort);
            ub.AddParameter("min", mindate);
            ub.AddParameter("max", maxdate);
            ub.AddParameter("min", min);
            ub.AddParameter("max", max);
            ub.AddParameter("order", order);

            return CreateApiTask<Comment>(ub, filterObj, "/comments/{ids}");
        }
    }

    public interface ICommentMethods
    {
        /// <summary>
        /// Get all comments on the site. (API Method: "/comments")
        /// </summary>
        Task<StacManResponse<Comment>> GetAll(string site, string filter = null, int? page = null, int? pagesize = null, DateTime? fromdate = null, DateTime? todate = null, Comments.Sort? sort = null, DateTime? mindate = null, DateTime? maxdate = null, int? min = null, int? max = null, Order? order = null);

        /// <summary>
        /// Get comments identified by a set of ids. (API Method: "/comments/{ids}")
        /// </summary>
        Task<StacManResponse<Comment>> GetByIds(string site, IEnumerable<int> ids, string filter = null, int? page = null, int? pagesize = null, DateTime? fromdate = null, DateTime? todate = null, Comments.Sort? sort = null, DateTime? mindate = null, DateTime? maxdate = null, int? min = null, int? max = null, Order? order = null);

    }
}

#pragma warning restore 1591
