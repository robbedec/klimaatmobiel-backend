using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Domain.Models.Domain
{
    public class CategoryTemplate
    {
        public long CategoryTemplateId { get; set; }

        public string CategoryName { get; set; }
        public string CategoryDescr { get; set; }
        public bool AddedByGO { get; set; }

    }
}
