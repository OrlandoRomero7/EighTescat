
namespace TescatGlobalServer.Data.Models
{
    public  class UserCredentials
    {
        public Guid ID_CREDENTIALS{ get; set; }

        public int? ID_USER { get; set; }

        public string? PORTAL_USER { get; set; }

        public string? PORTAL_PASS{ get; set; }

        public string? CASA_USER { get; set; }

        public string? CASA_PASS { get; set; }

        public string? MOZART_USER { get; set; }

        public string? MOZART_PASS { get; set; }

        public string? DARWIN_USER{ get; set; }

        public string? DARWIN_PASS { get; set; }

        public string? VPN_USER { get; set; }

        public string? VPN_PASS { get; set; }

        public DateTime? LAST_MODIF { get; set; }

        //[Timestamp]
        //public byte[]? Timestamp { get; set; }
    }
}