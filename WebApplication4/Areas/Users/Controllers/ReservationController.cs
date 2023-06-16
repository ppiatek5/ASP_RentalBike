using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data.Entity;
using System.Xml.Linq;
using WebApplication4.DB;
using WebApplication4.Models;
using WebApplication4.Repository;

namespace WebApplication4.Areas.Users.Controllers
{
    [Area("Users")]
    public class ReservationController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly IRepository<Reservation> _reservationRepository;
        private readonly IMapper _mapper;

        public ReservationController(IRepository<Reservation> reservationRepository, IMapper mapper, ApplicationDbContext context)
        {
            _reservationRepository = reservationRepository;
            _mapper = mapper;
            _context = context;
        }

        // GET: UsersController
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Index()
        {
            List<Reservation> result = new List<Reservation>();
            result = (await _reservationRepository.GetAll()).Include(r => r.VehicleId).ToList();
            return View(result);

        }


        public async Task<IActionResult> GetSingleVehicleById(int id)
        {
            Reservation result;
            result = await (_reservationRepository.GetSingle(id));
            return View(result);
        }


        // GET: UsersController/Create
        public ActionResult Create()
        {
            ViewData["VehicleId"] = new SelectList(_context.Vehicle_1, "Id", "Name");
            return View();
        }
        [Authorize(Roles = "Administrator")]
        public ActionResult CreateAdmin()
        {
            ViewData["VehicleId"] = new SelectList(_context.Vehicle_1, "Id", "Name");
            return View();
        }

        // POST: UsersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Reservation reservation)
        {
            Reservation result;
            result = await _reservationRepository.Create(reservation);
            ViewData["VehicleId"] = new SelectList(_context.Vehicle_1, "Id", "Name", reservation.VehicleId);

            return View(result);
            
            
        }
        [Authorize(Roles = "Administrator")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAdmin(Reservation reservation)
        {
            Reservation result;
            result = await _reservationRepository.Create(reservation);
            ViewData["VehicleId"] = new SelectList(_context.Vehicle_1, "Id", "Name", reservation.VehicleId);

            return View(result);

        }
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Delete(Reservation reservation)
        {
            _reservationRepository.Delete(reservation);
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Edit(Reservation reservation)
        {
            var result = await _reservationRepository.Update(reservation);
            return View(result);
        }

    }
}
