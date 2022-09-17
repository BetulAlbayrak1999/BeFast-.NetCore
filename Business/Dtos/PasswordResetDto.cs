

namespace Business.Dtos
{
    public class PasswordResetDto
    {
        public string Email { get; set; }
        public string Token { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
