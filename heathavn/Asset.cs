using System;

namespace heathavn
{
    public class Asset
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public double PerformanceRating { get; set; }
        public DateTime MaintenanceSchedule { get; set; }
    }
}
