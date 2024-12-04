using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axurance.Models
{
	public class MD_HRM_OFF_CATG
	{
		[Key]
		[Column("OFF_CATG_CD")]
		public required string Id { get; set; }

		[Column("OFF_CATG_NM")]
		public String? OffCatgNm { get; set; }

		[Column("SHORT_NM")]
		public String? ShortNm { get; set; }

		[Column("I_USR")]
		public string? IUsr { get; set; }

		[Column("I_DT")]
		public DateTime IDt { get; set; }

		[Column("U_USR")]
		public String? UUsr { get; set; }

		[Column("U_DT")]
		public DateTime? UDt { get; set; }
	}
}
