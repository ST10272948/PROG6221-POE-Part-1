using Microsoft.AspNetCore.Mvc;

namespace ST10272948_PART_1.Controllers
{
    public class ClaimController : Controller
    {
        public IActionResult SubmitClaim()
        {
            // Create an instance of the ViewModel and pass it to the view
            var model = new ClaimViewModel();
            return View(model);
        }

        // POST: /Claim/SubmitClaim
        [HttpPost]
        public IActionResult SubmitClaim(ClaimViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Handle form submission logic
                // Example: Save claim details and file, then set status
                model.Status = "Claim submitted successfully!";
            }
            else
            {
                model.Status = "There was an error submitting your claim.";
            }

            // Return the view with the model to display status or validation messages
            return View(model);
        }
    }
}
