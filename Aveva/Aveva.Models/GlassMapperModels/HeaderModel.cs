using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aveva.Models.GlassMapperModels
{
    [Serializable]
    [SitecoreType(TemplateId = "{0EBD4240-1D1F-42D1-B966-636402D97E9F}", AutoMap = true)]
    public class HeaderModel
    {
        [SitecoreInfo(SitecoreInfoType.Url)]
        public virtual string ItemUrl { get; set; }

        [SitecoreField]
        //[SitecoreInfo(SitecoreInfoType.Url)]
        public virtual Image Logo { get; set; }

        [SitecoreField("LogoIMageAlt")]
        public virtual string LogoImageAlt { get; set; }

        [SitecoreChildren(IsLazy = false)]
        public IEnumerable<ItemLinkModel> Items { get; set; }
        
        //public HeaderModel()
        //{
        //    this.Items = new List<ItemLinkModel>();
        //}
    }
}
