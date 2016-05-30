using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aveva.Models.GlassMapperModels
{
    [Serializable]
    [SitecoreType(TemplateId = "{09A162A8-768C-4975-8F34-5FC37FB0AEC3}", AutoMap = true)]
    public class DataTest
    {
        [SitecoreField("Name")]
        public string Name { get; set; }

        [SitecoreField("Surname")]
        public string Surname { get; set; }

        [SitecoreField("Age")]
        public string Age { get; set; }
    }
}
