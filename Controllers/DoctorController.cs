using BaseRepository.Models;
using BaseRepository.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BaseRepository.Controllers
{
    public class DoctorController : Controller
    {
        private readonly IGenericRepository<Doctor> _doctorRepo;

        public DoctorController(IGenericRepository<Doctor> doctorRepo)
        {
            _doctorRepo = doctorRepo;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("dropdown")]
        public async Task<IActionResult> GetForDropdown()
        {
            var doctors = await _doctorRepo.GetAllAsync();
            return Ok(doctors);
        }
    }
}
