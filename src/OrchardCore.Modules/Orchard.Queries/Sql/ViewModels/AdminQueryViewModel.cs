using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Orchard.Queries.Sql.ViewModels
{
    public class AdminQueryViewModel
    {
        public string DecodedQuery { get; set; }
        public string Parameters { get; set; } = "";

        [BindNever]
        public string RawSql { get; set; }

        [BindNever]
        public string RawParameters{ get; set; }

        [BindNever]
        public TimeSpan Elapsed { get; set; } = TimeSpan.Zero;

        [BindNever]
        public IEnumerable<dynamic> Documents { get; set; } = Enumerable.Empty<dynamic>();
    }
}