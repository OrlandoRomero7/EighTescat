

namespace TescatGlobalServer.Data.Models
{
    public partial class CompleteUserData
    {
        public User? User { get; set; }
        public UserCredentials? Credentials { get; set; }
        public UserEmails? Emails { get; set; }

        public UserPC? Computers { get; set; }

    }
}