﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Models;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productservice;
        public ProductController(IProductService productservice)
        {
            _productservice = productservice;
        }
      
        public IActionResult Index(int page=1,int category=0)//sıfır olursa hepsi gelir
        {
            int pageSize = 10;
            var products = _productservice.GetByCategory(category);
            ProductListViewModel model = new ProductListViewModel
            {
                Products = products.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                PageCount=(int)Math.Ceiling(products.Count/(double)pageSize),
                PageSize=pageSize,
                CurrentCategory=category,
                CurrentPage=page
            };
            return View(model);
        }

        //public string Session()
        //{
        //    HttpContext.Session.SetString("city", "Ankara");
        //    HttpContext.Session.SetInt32("age", 32);

        //    HttpContext.Session.GetString("city");
        //    HttpContext.Session.GetInt32("age");
             
        //}

        //public IActionResult AddToCart()
        //{
             
        //}
    }
}