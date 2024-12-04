using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axurance.Models
{
	public class REG_HRM_OFFICE
	{
		[Key]
		[Column("OFFICE_CD")]
		public string Id { get; set; }

		[Column("OFF_CLS_DT")]
		public DateTime? OffClsDt { get; set; }

		[Column("OFF_ACT_DT")]
		public DateTime? OffActDt { get; set; }

		[Column("OLD_OFFICE_CD")]
		public string? OldOfficeCd { get; set; }

		[Column("INCHARGE_DT_TO")]
		public DateTime? InchargeDtTo { get; set; }

		[Column("INCHARGE_DT_FROM")]
		public DateTime? InchargeDtFrom { get; set; }

		[Column("INCHARGE_EMP_GID")]
		public long? InchargeEmpGid { get; set; }

		[Column("OFFICE_STATUS")]
		public int? OfficeStatus { get; set; }

		/*[Column("WEB_ADDRESS")]
        public string WebAddress { get; set; }

        [Column("MAIL_ADDRESS")]
        public string MailAddress { get; set; }*/

		[Column("OFF_SUB_CAT")]
		public int? OffSubCat { get; set; }

		[Column("ACCOUNT_EXIST")]
		public int? AccountExist { get; set; }

		[Column("OFF_CATG_CD")]
		public string? OffCatgCdId { get; set; }
		[Column("POST_CODE")]
		public string? PostCode { get; set; }

		[Column("SHORT_NM")]
		public string? ShortNm { get; set; }


		[Column("OFFICE_NM")]
		public string? OfficeNm { get; set; }

		[Column("U_DT")]
		public DateTime? UDt { get; set; }

		[Column("U_USR")]
		public string? UUsr { get; set; }

		[Column("I_USR")]
		public string? IUsr { get; set; }

		[Column("I_DT")]
		public DateTime IDt { get; set; }

		public MD_HRM_OFF_CATG? OffCatgCd { get; set; }
	}
}
