namespace TescatGlobalServer.Data.Models
{
    public class Storage
    {
        public Guid ID_STORAGE { get; set; }

        public string? TYPE { get; set; }

        public int? TOTAL_STRGE { get; set; }

        public int? AVAILABLE_STRGE { get; set; }

        public int? USED_STRGE { get; set; }

        public string? MODEL { get; set; }

        public string? STATE { get; set; }

        public string? USE_TIME { get; set; }

        public long? NUMBER_READ { get; set; }

        public long? NUMBER_WRITE { get; set; }

        public int? READ_SPEED { get; set; }

        public int? WRITE_SPEED { get; set; }

        public long? GBW { get; set; }

        public Guid? ID_PC { get; set; }
    }
}
