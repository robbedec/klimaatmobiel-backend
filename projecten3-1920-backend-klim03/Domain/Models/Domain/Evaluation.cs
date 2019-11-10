using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projecten3_1920_backend_klim03.Domain.Models.Domain
{
    public class Evaluation
    {
        public long EvaluationId { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }

        public bool Extra { get; set; }


        public Evaluation()
        {

        }
    }
}
