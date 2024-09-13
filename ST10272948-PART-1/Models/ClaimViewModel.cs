namespace ST10272948_PART_1.Models
{
    public class ClaimViewModel
    {
        public decimal Amount { get; set; }
        public DateTime SubmissionDate { get; set; }
        public required IFormFile SupportingDocument { get; set; }
        public string Status { get; set; } = string.Empty;
    }
}
