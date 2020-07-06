using businessLogicalLayer;
using DALlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CRUDByApi.Controllers
{
    public class masterController : ApiController
    {
        [HttpPost]
        public string Insert(CRUDBLL data)
        {
            return CRUDDAL.InsertData(data);
        }
    }
}
