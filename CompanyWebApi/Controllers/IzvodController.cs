using CompanyWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CompanyWebApi.Controllers
{
    public class IzvodController : ApiController
    {
        public IHttpActionResult Get()
        {
            BankApiService.ServiceBankClient bs = new BankApiService.ServiceBankClient();
            
            BankApiService.UplatnicaModel[] izvrseneUplate = bs.GetIzvod();

            return Ok(izvrseneUplate);
        }
    }
}
