using UtilityManager.CommonModels;

namespace UserAppSecurity.Models.Entity
{
    public class REG_USER_GROUPS : ModelBase<REG_USER_GROUPS>
    {
        public int GROUP_ID { get; set; }
        public string GROUP_NAME { get; set; }
        public string GROUP_DESCRIP { get; set; }
        public int APPROVE_STATUS_FLAG { get; set; }
        public string BUID { get; set; }
    }
}
