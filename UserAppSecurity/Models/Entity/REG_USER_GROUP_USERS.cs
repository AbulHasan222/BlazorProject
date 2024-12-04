using UtilityManager.CommonModels;

namespace UserAppSecurity.Models.Entity
{
    public class REG_USER_GROUP_USERS : ModelBase<REG_USER_GROUP_USERS>
    {
        public int GROUP_ID { get; set; }
        public string USER_ID { get; set; }
        public int APPROVE_STATUS_FLAG { get; set; }
        public string BUID { get; set; }

    }
}
