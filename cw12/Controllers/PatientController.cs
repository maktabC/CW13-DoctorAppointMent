using cw12.DataBase;
using Microsoft.AspNetCore.Mvc;

namespace cw12.Controllers
{
    public class PatientController : Controller
    {
        public IActionResult GetAllReservation()
        {
            return View();
        }

        public IActionResult SearchByCategory(int categoryId)
        {
            var getReserve = Tempdatabase.reservations.Where(r => r.Doctor.Skill.Id == categoryId).ToList();
            return View();
        }
    }
}
