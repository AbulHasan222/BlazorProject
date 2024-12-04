using UtilityManager.CommonModels;

namespace FintechHub.UI.Models.Entity
{
    public class USER_PROFILE:ModelBase<USER_PROFILE>
    {
        public string USER_ID { get; set; }
        public string USER_NAME { get; set; }
        public string USER_DESCRIP { get; set; }
        public string HOME_BRANCH_ID { get; set; }
        public string HOME_OFFICE_ID { get; set; }
        public int SMS_ADMIN_ROLE_FLAG { get; set; }
        public string PASSWORD_STRING { get; set; }
        public int FORCED_PASSWORD_CHANGED_FLAG { get; set; }
        public DateTime LAST_PASSWORD_CHANGED_ON { get; set; }
        public DateTime LAST_SIGNED_ON { get; set; }
        public int USER_STATUS_ACTIVE_FLAG { get; set; }
        public DateTime USER_STATUS_CHANGED_ON { get; set; }
        public string USER_PROFILE_CLOSED_FLAG { get; set; }
        public DateTime USER_PROFILE_CLOSED_ON { get; set; }
        public int BUILT_IN_USER_FLAG { get; set; }
        public int FAILED_LOGIN_ATTEMPTS_NOS { get; set; }
        public string PASSWORD_EXPIRY_ALERT_MSG { get; set; }
        public int BANK_STAFF_FLAG { get; set; }
        public string EMPLOYEE_ID { get; set; }
        public string PAC { get; set; }
        public int ANY_BR_REPORT_ACCESS_FLAG { get; set; }
        public string SESSION_ID { get; set; }
        public string SESSION_TERMINAL_IP { get; set; }
        public string SESSION_CREATED { get; set; }
        public string SESSION_EXPIRES { get; set; }
        public string SESSION_LAST_HIT { get; set; }
        public string SESSION_IS_ACTIVE { get; set; }
        public string SESSION_LOCKED { get; set; }
        public string TERMINAL_IP { get; set; }
        public string LOG_IN_APP_TERMINAL_IP { get; set; }
        public string LOG_IN_USER_TERMINAL_IP { get; set; }
        public string APP_LOG_IN_TIME { get; set; }
        public string APP_LOG_OUT_TIME { get; set; }
        public string USER_STATUS_CHANGE_REASON { get; set; }
        public string USER_PROFILE_CHANGE_REASON { get; set; }
        public string SESSION_EXPIRES_DT { get; set; }
        public string USER_LOGIN_BROWSER_INFO { get; set; }

    }
}
