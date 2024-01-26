
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace TescatGlobalServer.Data.Models
{
    public class UserEmails
    {
        public Guid USER_EMAILS_ID { get; set; }

        public int? ID_USER { get; set; }


        public string? EMAIL_1 { get; set; }

        public string? PASS_1 { get; set; }

        public string? EMAIL_2 { get; set; }

        public string? PASS_2 { get; set; }

        public string? EMAIL_3 { get; set; }

        public string? PASS_3 { get; set; }


        }
}
