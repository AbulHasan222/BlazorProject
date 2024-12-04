using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Axurance.Models;

namespace Axurance.Repositories.Contacts
{
	public interface IHRMOffice
	{
		List<REG_HRM_OFFICE> GetHRMOfficeList();
		REG_HRM_OFFICE GetHRMOfficeGK(string officeCD);
	}
}
