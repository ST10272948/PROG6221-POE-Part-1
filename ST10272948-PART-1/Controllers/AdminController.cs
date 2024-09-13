using Microsoft.AspNetCore.Mvc;
using ST10272948_PART_1.Models;

namespace ST10272948_PART_1.Controllers
{
    public class AdminController : Controller
    {
        private static List<Claim> _claims = new List<Claim>();

        [HttpGet]
        public IActionResult ApprovalDashboard()
        {
            // Retrieve all claims
            return View(_claims);
        }

        [HttpGet]
        public IActionResult Approve(int id)
        {
            // Update claim status to Approved
            var claim = _claims.Find(c => c.ClaimID == id);
            if (claim != null)
            {
                claim.Status = "Approved";
            }
            return RedirectToAction("ApprovalDashboard");
        }

        [HttpGet]
        public IActionResult Reject(int id)
        {

            var claim = _claims.Find(c => c.ClaimID == id);
            if (claim != null)
            {
                claim.Status = "Rejected";
            }
            return RedirectToAction("ApprovalDashboard");
        }
    }
}
