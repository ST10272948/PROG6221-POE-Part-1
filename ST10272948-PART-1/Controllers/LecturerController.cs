using Microsoft.AspNetCore.Mvc;
using ST10272948_PART_1.Models;

namespace ST10272948_PART_1.Controllers
{
    public class LecturerController : Controller
    {
        private static List<Claim> _claims = new List<Claim>();

        [HttpGet]
        public IActionResult SubmitClaim()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SubmitClaim(Claim claim)
        {
            // Add logic to save the claim
            _claims.Add(claim);
            claim.Status = "Submitted";
            return View(claim);
        }

        [HttpGet]
        public IActionResult TrackClaims()
        {
            // Return all claims submitted by the lecturer
            return View(_claims);
        }
    }
}
