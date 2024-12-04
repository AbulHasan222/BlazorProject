using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using UtilityManager.CommonModels;

namespace UserAppSecurity.Models.Entity
{
    public class REG_USER_GRANT_CLIENT_PROD : ModelBase<REG_USER_GRANT_CLIENT_PROD>
    {
        [Required]
        public string USER_ID { get; set; }
        [Required]
        public string PRODUCT_ID { get; set; }
        [Required]
        public string OPS_TYPE_ID { get; set; }
        [Required]
        public bool ALLOW_NFT { get; set; }
        [Required]
        public bool ALLOW_FTN_CREDIT { get; set; }
        public string BUID { get; set; }
        [Required]
        public bool ALLOW_FTN_DEBIT { get; set; }
        [Required]
        public int APPROVE_STATUS_FLAG { get; set; }
        [Required]
        public bool ALLOW_FTN { get; set; }
        [NotMapped]
        public string PRODUCT_NAME { get; set; }
        [NotMapped]
        public string AUTH_STATUS_ID { get; set; }
    }
}
