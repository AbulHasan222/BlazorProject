using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Axurance.Models;
using Axurance.Repositories.Contacts;
using DataAccessManager;

namespace Axurance.Repositories.Repo
{
	public class HRMOffice: IHRMOffice
	{
		int _constAppId = 9;

		public HRMOffice() 
		{
			
		}
		public List<REG_HRM_OFFICE> GetHRMOfficeList()
		{
			List<REG_HRM_OFFICE> hrmOfficeList = new List<REG_HRM_OFFICE>();

			DataConnector objDataConnector = DataConnector.GetDataConnector();
			DbCommand objDbCommand = objDataConnector.GetDBCommand(false, System.Data.IsolationLevel.Serializable, _constAppId);

			try
			{
				List<DBParam> objList = new List<DBParam>();
				//objList.Add(new DBParam("p_GROUP_NAME", groupName, false));
				objList.Add(new DBParam("pERRORCODE", DBNull.Value, ParameterDirection.Output));
				objList.Add(new DBParam("pERRORMESSAGE", DBNull.Value, ParameterDirection.Output));

				DbDataReader dr = objDataConnector.GetResultAsReader(objDbCommand, "pkg_gl.pro_office_view", CommandType.StoredProcedure, objList);

				if (dr.HasRows)
				{
					while (dr.Read())
					{
						REG_HRM_OFFICE hrmOffice = new REG_HRM_OFFICE();
						//string GROUP_ID = dr["GROUP_ID"].ToString();
						hrmOffice.Id = dr["ID"].ToString();
						hrmOffice.ShortNm = dr["SHORTNM"].ToString();
						hrmOffice.OldOfficeCd = dr["OLDOFFICECD"].ToString();
						//string APP_STATUS_FLAG = dr["APPROVE_STATUS_FLAG"].ToString();

						hrmOfficeList.Add(hrmOffice);
					}
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return hrmOfficeList;
		}
		public REG_HRM_OFFICE GetHRMOfficeGK(string officeCD)
		{
			REG_HRM_OFFICE hrmOffice = new REG_HRM_OFFICE();
			DataConnector objDataConnector = DataConnector.GetDataConnector();
			DbCommand objDbCommand = objDataConnector.GetDBCommand(false, System.Data.IsolationLevel.Serializable, _constAppId);

			try
			{
				List<DBParam> objList = new List<DBParam>();
				objList.Add(new DBParam("p_office_cd", officeCD, false));
				objList.Add(new DBParam("p_office_view", DBNull.Value, ParameterDirection.Output));
				objList.Add(new DBParam("p_error", DBNull.Value, ParameterDirection.Output));

				DbDataReader dr = objDataConnector.GetResultAsReader(objDbCommand, "pkg_gl.REG_HRM_OFFICE_GK", CommandType.StoredProcedure, objList);

				if (dr.HasRows)
				{
					while (dr.Read())
					{
						//string GROUP_ID = dr["GROUP_ID"].ToString();
						hrmOffice.Id = dr["ID"].ToString();
						hrmOffice.ShortNm = dr["SHORTNM"].ToString();
						hrmOffice.OldOfficeCd = dr["OLDOFFICECD"].ToString();
						//string APP_STATUS_FLAG = dr["APPROVE_STATUS_FLAG"].ToString();

						
					}
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return hrmOffice;
		}
	}
}
