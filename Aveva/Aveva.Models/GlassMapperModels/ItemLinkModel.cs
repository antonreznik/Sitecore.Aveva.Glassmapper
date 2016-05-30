using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aveva.Models.GlassMapperModels
{
    public class ItemLinkModel
    {
        [SitecoreField("Name")]
        public virtual string Name { get; set; }

        [SitecoreInfo(SitecoreInfoType.Url)]
        public virtual string Url { get; set; }

        [SitecoreField("Date")]
        public virtual List<ItemLinkModel> Items { get; set; }
    }
}
