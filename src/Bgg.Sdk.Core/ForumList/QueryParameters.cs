﻿using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bgg.Sdk.Core.ForumList
{
    public class QueryParameters
    {
        public QueryParameters(int id)
        {
            Id = id;
        }

        [AliasAs("id")]
        public int Id { get; set; }
        [AliasAs("type")]
        public ForumListType ForumListType { get; set; } = ForumListType.Thing;
    }
}
