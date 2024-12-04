using UtilityManager.CommonModels;

namespace FintechHub.UI.Models.Entity
{
    public class MD_APP_MODULES : ModelBase<MD_APP_MODULES>

    {
        public string MODULE_ID { get; set; }
        public string MODULE_NM { get; set; }
        public bool ENABLED_FLAG { get; set; }
        public int QUICK_ROUTE_STRT { get; set; }
        public int QUICK_ROTE_END { get; set; }
        public int APP_ID { get; set; }
    }
}
