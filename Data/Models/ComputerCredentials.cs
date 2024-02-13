
namespace TescatGlobalServer.Data.Models
{
    public class ComputerCredentials
    {
        public Guid ID_PC { get; set; }

        public string? PC_USER { get; set; }

        public string? PC_PASSWORD { get; set; }

        public string? ID_ANYDESK { get; set; }

        public string? ANYDESK_PASS { get; set; }

        public string? NETWORK_USER { get; set; }

        public string? COMUN_USER { get; set; }

        public string? COMUN_PASS { get; set; }

        public int? MOZART_RDP_USER { get; set; }
        public int? MOZART_RDP_PASS { get; set; }
        public int? DARWIN_VANTEC_USER { get; set; }
        public int? DARWIN_VANTEC_PASS { get; set; }
        public DateTime? LAST_MODIF { get; set; }
    }
}