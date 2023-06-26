﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesWebApp.Data;

namespace MoviesWebApp.Controllers
{
	public class MoviesController : Controller
	{

		private readonly ApplicationDbContext _context;

        public MoviesController(ApplicationDbContext context)
        {
			_context = context;
        }
        public async Task<IActionResult> Index()
		{
			var Movies = await _context.Movies.ToListAsync();
			return View(Movies);
		}
	}
}
