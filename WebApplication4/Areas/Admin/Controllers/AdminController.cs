using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication4.DB;
using WebApplication4.Models;

namespace WebApplication4.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Administrator")]

    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/VehicleTypes

        public async Task<IActionResult> Index()
        {
            return View();
       
        }

        // GET: Admin/VehicleTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            return View();
        }

        // GET: Admin/VehicleTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/VehicleTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.


        // GET: Admin/VehicleTypes/Edit/5
        public async Task<IActionResult> Edit()
        {
            return View();
        }

        // POST: Admin/VehicleTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id)
        {   
            return View();
        }

        // GET: Admin/VehicleTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {      
            return View();
        }





    }
}
