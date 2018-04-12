using AuburnRandall.Core;
using AuburnRandall.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace AuburnRandall.Web.Api
{
    public class PageController : ApiController
    {
        public IHttpActionResult GetPages()
        {
            return Ok(PageRepository.GetPages());
        }
    }
}