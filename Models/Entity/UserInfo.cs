using UtilityManager.CommonModels;

namespace FintechHub.UI.Models.Entity
{
    public class UserInfo : ModelBase<UserInfo>
    {
        public string USER_ID { get; set; }
        public string LIMIT_TYPE_ID { get; set; }
        public string LIMIT_AMOUNT { get; set; }
        public string APPROVE_STATUS_FLAG { get; set; }
        public string REMARKS { get; set; }
    }
}
