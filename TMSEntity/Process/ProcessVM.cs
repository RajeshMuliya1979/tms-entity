namespace TMS.Entity
{
    public class ProcessIdVM
    {
        public long ProcessId { get; set; }    
    }

    public class ProcessVM : DataItemFieldsVM
    {
        public long ProcessId { get; set; }
        public object OrganizationList { get; set; }
        public string ProcessName { get; set; }
        public string SubProcessName { get; set; }
        public object ActivityName { get; set; }
        public decimal EstimatedDuration { get; set; }
        public bool IsProductive { get; set; }
        public bool IsBillable { get; set; }
    }

    public class ProcessListVM : DataListVM<ProcessVM>
    {
        
    }

    public class ProcessListFilterVM : PageFilterVM
    {
        public string ProcessName { get; set; }
        public decimal? EstimatedDuration { get; set; }
        public long? UserId { get; set; }
    }

    public class ActivityName
    {
        public string value { get; set; }
    }
}
