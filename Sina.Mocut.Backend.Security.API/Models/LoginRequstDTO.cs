namespace Sina.Mocut.Backend.Security.API.Models
{
    public class LoginRequstDTO
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string PhoneNumber { get; set; }

        public LoginRequstDTO(string? password, string? username , string phoneNumber)
        {
            Password = password;
            Username = username;
            PhoneNumber = phoneNumber;

        }
    }
}
