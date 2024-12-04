using System.ComponentModel.DataAnnotations;
using UtilityManager.CommonModels;

namespace FintechHub.UI.Models.Entity
{
    public class PARAM_APP_CONN_CRED : ModelBase<PARAM_APP_CONN_CRED>
    {
        [Required]
        public int APP_ID { get; set; }
        public string APP_NM { get; set; }
        public string DATABASE { get; set; }
        public string DB_USER { get; set; }
        public string DB_PASS { get; set; }
        public string DB_TYPE { get; set; }

    }
}
