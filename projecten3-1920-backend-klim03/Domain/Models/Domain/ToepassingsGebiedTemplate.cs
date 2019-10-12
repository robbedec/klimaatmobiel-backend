using System;
namespace projecten3_1920_backend_klim03.Domain.Models.Domain
{
    public class ToepassingsGebiedTemplate
    {
		public long ToepassingsGebiedTemplateId { get; set; }

		public string ToepassingsGebiedNaam { get; set; } // kan enum zijn
		public string ToepassingsGebiedOmschrijving { get; set; }



		public ToepassingsGebied()
		{
		}
	}
}
