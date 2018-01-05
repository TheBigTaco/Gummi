﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Gummi.Models;

namespace Gummi.Controllers
{
	public class ProductController : Controller
	{
		private GummiContext db = new GummiContext();
		public IActionResult Index()
		{
			return View(db.Products.ToList());
		}
	}
}