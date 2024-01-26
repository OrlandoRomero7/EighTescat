using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TescatGlobalServer.Data.Models
{
    public class User
    {

        [Required]
        public int ID_USER { get; set; }

        //[Required]
        public string? NAME { get; set; } = default!;

        public string? DEPT { get; set; } = default!;

        //[Required]
        public string? AREA { get; set; } = default!;

        public string? OFFICE { get; set; } = default!;

        //[Required]
        public string? POSITION { get; set; } = default!;
        //[Required]
        public DateTime? ENTRY_DATE { get; set; }

        [NotMapped]
        public DateTime NON_NULL_ENTRY_DATE
        {
            get => ENTRY_DATE.GetValueOrDefault();
            set => ENTRY_DATE = value;
        }

        public DateTime? LAST_WORKING_DATE { get; set; }

        public int? TEL { get; set; }

        public int? TEL_KEY { get; set; }

        public long? CEL { get; set; }

        public bool? WEB_PRIVILEGES { get; set; }

        [NotMapped]
        public bool NON_NULL_WEB_PRIVILEGES
        {
            get => WEB_PRIVILEGES.GetValueOrDefault();
            set => WEB_PRIVILEGES = value; 
        }

        //[Required]
        public DateTime? LAST_MODIF { get; set; }

        public string? IMAGE_NAME { get; set; }

        [Timestamp]
        public byte[]? Timestamp { get; set; }

    }
}
