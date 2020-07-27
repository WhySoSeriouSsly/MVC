using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Microsoft.AspNetCore.Mvc;
using TestApi.Models;

namespace TestApi.Controllers
{
    public class testProductController : Controller
    {
        //localhost:0000/testProduct/Index
        private IProductDal _productDal;
        public testProductController(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public JsonResult Index()
        {
            var model = new testProductListModel
            {
                Products = _productDal.GetList(),
                
            };
            return Json(model);
        }
       
    }
}
