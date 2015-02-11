﻿using System.Collections.Generic;

namespace VirtoCommerce.Web.Core.DataContracts.Contents
{
    public class DynamicContentItemGroup
    {
        public DynamicContentItemGroup(string groupName)
        {
            GroupName = groupName;
            Items = new List<DynamicContentItem>();
        }

        public List<DynamicContentItem> Items { get; private set; }

        public string GroupName { get; set; }
    }
}
