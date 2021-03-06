﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Premium.Commons.Types
{
    public abstract class PagedQueryBase : IPagedQuery
    {
        public int Page { get; set; }
        public int Results { get; set; }
        public string OrderBy { get; set; }
        public string SortOrder { get; set; }
    }
}

