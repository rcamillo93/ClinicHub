using ClinicHub.Core.Entity;
using ClinicHub.Core.Enums;

namespace ClinicHub.Application.ViewModel
{
    public class UserViewModel
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public UserRoleEnum Role { get; set; }
        public Doctor? Doctor { get; set; }

        public UserViewModel FromEntiy(User user)
        {
            return new UserViewModel
            {
                FullName = user.FullName,
                Email = user.Email,
                Phone = user.Phone,
                Role = user.Role,
                Doctor = user.Doctor
            };
        }
    }
}