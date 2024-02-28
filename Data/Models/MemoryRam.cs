namespace TescatGlobalServer.Data.Models
{
    public class MemoryRam
    {
        public Guid ID_RAM { get; set; }

        public string? MODEL { get; set; }

        public string? TYPE_RAM { get; set; }

        public int? SIZE { get; set; }

        public string? SPEED { get; set; }

        public Guid? ID_PC { get; set; }
    }
}

