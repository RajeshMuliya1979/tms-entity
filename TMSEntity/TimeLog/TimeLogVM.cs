using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Entity
{
    public class TimeLogVM
    {
        public long UserTableId { get; set; }
        public string UserName { get; set; }
        public string CPAName { get; set; }
        public string ClientName { get; set; }
        public long? TaskId { get; set; }
        public string? TaskName { get; set; }
        public string? StartTime { get; set; }
        public string? EndTime { get; set; }
        public TimeSpan? TotalTime { get; set; }
        public string? BreakStartTime { get; set; }
        public string? BreakEndTime { get; set; }
        public TimeSpan? BreakTotalTime { get; set; }
        public long? ProcessId { get; set; }
        public string? ProcessName { get; set; }

    }

    public class TimeLogListVM : DataListVM<TimeLogVM>
    {
        
    }

    public class TimeLogFilterVM : PageFilterVM
    {
        public DateTime TimelineDate { get; set; }
        public long? UserId { get; set; }
        public long? CPAId { get; set; }
        public long? ClientId { get; set; }
    }

    public class RefreshTimeDuration
    {
        public DateTime TimelineDate { get; set; }
        public long? UserId { get; set; }
        public long? WorkPlanId { get; set; }
    }
}
