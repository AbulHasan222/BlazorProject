using UtilityManager.CommonModels;

namespace UserAppSecurity.Models.Entity
{
    public class MD_APP_FUNCTIONS : ModelBase<MD_APP_FUNCTIONS>
    {
        public int FUNCTION_ID { get; set; }
        public string FUNCTION_NM { get; set; }
        public string MODULE_ID { get; set; }
        public bool HO_FUNCTION_FLAG { get; set; }
        public bool RPT_VIEW_FLAG { get; set; }
        public bool RPT_PRINT_FLAG { get; set; }

        public bool RPT_GEN_FLAG { get; set; }
        public string APP_ROUTE { get; set; }
        public string ITEM_TYPE { get; set; }

        public bool ENABLED_FLAG { get; set; }
        public bool ALLOW_ANY_OFFICE_OPS_FLAG { get; set; }

        public string QUICK_ROUTE_NO { get; set; }
        public int IS_FINANCIAL { get; set; }
        public int APP_ID { get; set; }
    }
}
