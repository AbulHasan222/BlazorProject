using UtilityManager.CommonModels;

namespace FintechHub.UI.Models.Entity
{
    public class ParamLimitInfo : ModelBase<ParamLimitInfo>
    {
        public string LIMIT_TYPE_ID { get; set; }
        public string LIMIT_DESCRIPTION { get; set; }
        public string APPROVE_STATUS_FLAG { get; set; }
        public string RELATIVE_LIMIT_TYPE_ID { get; set; }

    }
}
