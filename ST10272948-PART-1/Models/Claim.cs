using System.ComponentModel.DataAnnotations;

namespace ST10272948_PART_1.Models
{
    public record Claim([property: Key] int ClaimID, [property: Required] decimal Amount, [property: Required] DateTime SubmissionDate, string SupportingDocument)
    {
        public string Status { get; set; } = "Pending";
    }
}
