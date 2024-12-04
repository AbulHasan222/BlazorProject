using UtilityManager.CommonModels;

namespace FintechHub.UI.Models.Entity
{
    public class UserAccessInfo : ModelBase<UserAccessInfo>
    {
        public string FunctionId { get; set; }
        public string FunctionName { get; set; }
        public string HOFunctionFlag { get; set; }
        public string AllowMaintAddFlag { get; set; }
        public string AllowMaintEditFlag { get; set; }
        public string AllowMaintDelFlag { get; set; }
        public string AllowMaintViewFlag { get; set; }
        public string AllowMaintAuthFlag { get; set; }
        public string AllowProcessFlag { get; set; }
        public string AllowReportViewFlag { get; set; }
        public string AllowReportPrintFlag { get; set; }
        public string AllowReportGenFlag { get; set; }
        public string AllowAnyOfficeOpsFlag { get; set; }
        public string ModuleId { get; set; }
        public string ModuleName { get; set; }
        public string AppRoute { get; set; }
        public string ItemType { get; set; }
        public string QuickRouteNo { get; set; }
        public string IsFinancial { get; set; }
    }
}
