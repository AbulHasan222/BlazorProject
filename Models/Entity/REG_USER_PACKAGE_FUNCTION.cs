using UtilityManager.CommonModels;

namespace FintechHub.UI.Models.Entity
{
    public class REG_USER_PACKAGE_FUNCTION : ModelBase<REG_USER_PACKAGE_FUNCTION>
    {
        public int PACKAGE_ID { get; set; }
        public int FUNCTION_ID { get; set; }
        public bool ALLOW_MAINT_ADD_FLAG { get; set; }
        public bool ALLOW_MAINT_EDIT_FLAG { get; set; }

        public bool ALLOW_MAINT_DEL_FLAG { get; set; }

        public bool ALLOW_MAINT_VIEW_FLAG { get; set; }
        public bool ALLOW_MAINT_AUTH_FLAG { get; set; }
        public bool ALLOW_PROCESS_FLAG { get; set; }
        public bool ALLOW_REPORT_VIEW_FLAG { get; set; }

        public bool ALLOW_REPORT_PRINT_FLAG { get; set; }

        public bool ALLOW_REPORT_GEN_FLAG { get; set; }

        public bool ALLOW_ANY_OFFICE_OPS_FLAG { get; set; }

        public int APPROVE_STATUS_FLAG { get; set; }

        public string BUID { get; set; }

        public string ROWID { get; set; }


    }
}
