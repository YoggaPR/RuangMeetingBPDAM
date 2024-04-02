using Microsoft.AspNetCore.Mvc;
using RuangMeetingBPDAM.DBContext;
using RuangMeetingBPDAM.Models;

namespace RuangMeetingBPDAM.Controllers
{
    public class FacilityController : Controller
    {
        private readonly AppDbContext db;

        public FacilityController(AppDbContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginSubmit(int id, string PIN)
        {
            try
            {
                var facilities = db.Facilities.Where(u => u.Id == id && u.PIN == PIN).Single();
                return View("Index", facilities);
            }
            catch (Exception ex) {
                Facilities facilities = new Facilities();
                facilities.PIN = "SOPODEL_52A";
                facilities.Participants = 10;
                facilities.Facility = "LG Demo TV\nDispenser\nProjector\nMicrophone\nLaser Pointer\nAC\nMeja\nKursi";
                facilities.StartDate = DateTime.Now;
                facilities.EndDate = DateTime.Now;
                facilities.StartTime = DateTime.Now;
                facilities.EndTime = DateTime.Now;
                facilities.Title = "Tes Meeting";
                facilities.Tower = "Sopodel Tower A";
                facilities.Floor = "52A";
                facilities.PIC = "John Safir";
                facilities.Email = "john.safir@gmail.com";
                
                return View("Index",facilities);
            }
            
        }
    }
}