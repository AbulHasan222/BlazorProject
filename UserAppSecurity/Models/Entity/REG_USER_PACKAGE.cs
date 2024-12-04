using UtilityManager.CommonModels;

namespace UserAppSecurity.Models.Entity
{
    public class REG_USER_PACKAGE : ModelBase<REG_USER_PACKAGE>
    {
        public int PACKAGE_ID { get; set; }
        public string? PACKAGE_NAME { get; set; }

        public string? PACKAGE_DESC { get; set; }

        public string? OPS_TYPE_ID { get; set; }
        public int APPROVE_STATUS_FLAG { get; set; }

        public string? BUID { get; set; }

    }
}
