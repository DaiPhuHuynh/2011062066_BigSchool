﻿using _2011062066_letranbaoduy.Models;
using _2011062066_letranbaoduy.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2011062066_letranbaoduy.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        private readonly ApplicationDbContext _dbContext;
        public CourseController()
        {
            _dbContext = new ApplicationDbContext();
        }
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel
            {
                Categories = _dbContext.Categories.ToList()
            };
            return View(viewModel);
        }
    }
}