using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SecurityAuthManager.Contracts;
using SecurityAuthManager.Entities;
using System.Net;


namespace FintechHub.UI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SecurityManagementController : ControllerBase
    {
        private readonly IUSER_REG _userRepo;
        public SecurityManagementController(IUSER_REG userRepo)
        {
                _userRepo = userRepo;
        }

        //[HttpPost]
        //public async Task<IActionResult> userReg(ApiRequestObject apiRequest)
        //{

        //    if (apiRequest == null)
        //    {

        //        return BadRequest();
        //    }

        //    try
        //    {
        //        var objmap = JsonConvert.DeserializeObject<USER_PROFILE>(apiRequest.BusinessData.ToString());
        //        USER_PROFILE user = _userRepo.userReg(objmap);
        //        return Ok(user);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);

        //    }

        //}
        [HttpPost]
        public async Task<IActionResult> GetIpInformation()
        {
            string IPAdress = Response.HttpContext.Connection.RemoteIpAddress.ToString();
            if (IPAdress == "::1")
            {
                string address = Dns.GetHostEntry(Dns.GetHostName()).AddressList.ToString();
                IPAdress = Dns.GetHostEntry(Dns.GetHostName()).AddressList[1].ToString();
            }
            return Ok(IPAdress);
        }


    }
}
