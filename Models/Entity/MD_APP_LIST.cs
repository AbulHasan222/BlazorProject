using UtilityManager.CommonModels;

namespace FintechHub.UI.Models.Entity
{
    public class MD_APP_LIST : ModelBase<MD_APP_LIST>
    {
        public int APP_ID { get; set; }
        public string? APP_NAME { get; set; }
        public string? APP_DESC
        {
            get; set;
        }
    }
}
