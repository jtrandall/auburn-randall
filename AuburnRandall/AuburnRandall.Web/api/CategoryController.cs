using AuburnRandall.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace AuburnRandall.Web.api
{
    public class CategoryController : ApiController
    {
        public IHttpActionResult GetCategories()
        {
            return Ok(CategoryRepository.GetCategories());
        }
    }
}