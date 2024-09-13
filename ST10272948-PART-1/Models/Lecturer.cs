using ST10272948_PART_1.Models;

namespace ST10272948.Models
{
    public class Lecturer
    {
        public int LecturerID { get; set; }

        public required string Name { get; set; }

        public required string Email { get; set; }

        public required List<Claim> Claims { get; set; }
    }
}
