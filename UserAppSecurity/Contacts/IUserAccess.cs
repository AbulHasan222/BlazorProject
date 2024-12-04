


using UserAppSecurity.Models.Entity;

namespace UserAppSecurity.Contacts
{
    public interface IUserAccess
    {
        public REG_USER_GROUP_USERS SaveGroupUsers(REG_USER_GROUP_USERS objRegUserGroupUsers);

        public REG_USER_GROUPS groupReg(REG_USER_GROUPS group);
        public List<REG_USER_GROUPS> GetGroupGA(string group);
        public List<USER_PROFILE> FetchUnAssignedUsers(string groupName);
        public List<USER_PROFILE> FetchAssignedUsers(string groupName);
        public PARAM_APP_CONN_CRED ParamAppSave(PARAM_APP_CONN_CRED paramApp);
        public List<PARAM_APP_CONN_CRED> GetParamAppGA(int paramApp);
        public List<PARAM_APP_CONN_CRED> GetParamAppGK(int paramApp);

        public List<ParamLimitInfo> GetAllParamLimitInfo();
        public List<UserInfo> GetUserGrantLimits(string User_ID);
        public USER_PROFILE GetRegUserProfileById(string User_ID);
        public List<UserInfo> UserGrantLimitReg(List<UserInfo> list_user_Info);

        public List<REG_USER_PACKAGE_FUNCTION> FetchAssignedRegUserPackageFuntion(int Package_ID);

        public string UpdateAssignedRegUserPackageFuntion(List<REG_USER_PACKAGE_FUNCTION> objregPackageFuncList);

        public REG_USER_PACKAGE FetchRegUserPackage(int Package_ID);

        public List<MD_APP_LIST> MdAppListGA();

        List<USER_PROFILE> GetRegUserProfile(string userId);
        List<REG_USER_GRANT_CLIENT_PROD> GetRegUserGrantClientAssign(string userId);

        List<REG_USER_GRANT_CLIENT_PROD> GetRegUserGrantClientUnAssign(string userId);
    }
}
