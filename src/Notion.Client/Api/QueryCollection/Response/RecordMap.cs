using System;
using System.Collections.Generic;

namespace Notion.Client
{
    public class RecordMap
    {
        public IDictionary<Guid, RoleValueWrapper<IBlock>> Block { get; set; }
        public IDictionary<Guid, RoleValueWrapper<Collection>> Collection { get; set; }
        public IDictionary<Guid, RoleWrapper> Space { get; set; }
    }
}
