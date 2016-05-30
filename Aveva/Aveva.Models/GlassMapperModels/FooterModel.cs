using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aveva.Models.GlassMapperModels
{
    [Serializable]
    [SitecoreType(TemplateId = "{0EBD4240-1D1F-42D1-B966-636402D97E9F}", AutoMap = true)]
    public class FooterModel
    {
        //[SitecoreField("Date")]
        [SitecoreField]
        public virtual string Date { get; set; }

        //[SitecoreField("Contacts")]
        [SitecoreField]
        public virtual string Contacts { get; set; }

        //[SitecoreField("Information")]
        [SitecoreField]
        public virtual string Information { get; set; }
    }
}
