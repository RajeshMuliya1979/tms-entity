using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Entity
{
    public class CPAReqVM
    {
        public long CPAId { get; set; }
    }

    public class TaskListResp : DropdownItemVM
    {
        public decimal EstimatedDuration { get; set; }
    }

    public class StatusListResp
    {
        public long Id { get; set; }
        public string Color { get; set; }
        public string StatusName { get; set; }
    }


    public class ClientAndTaskListResp
    {
        public List<DropdownItemVM> ClientList { get; set; }
        public List<TaskListResp> TaskList { get; set; }
        public List<StatusListResp> StatusList { get; set; }
        public List<TaskListResp> ProcessList { get; set; }
    }

    public class WorkPlanReqVM
    {
        public long WorkPlanId { get; set; }
        public long CPAId { get; set; }
        public long ClientId { get; set; }
        public long? ProcessId { get; set; }
        public long? TaskId { get; set; }
        public long StatusId { get; set; }
        public long? Quantity { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? TimelineDate { get; set; }
    }
    public class WorkPlanResultVM
    {
        public long WorkPlanId { get; set; }
    }

    public class WorkPlanFilterVM : PaginationMetaVM
    {
        public long? CPAId { get; set; }
        public long? ClientId { get; set; }
        public string GlobalSearch { get; set; }
        public long UserId { get; set; }
        public DateTime? TimelineDate { get; set; }

    }

    public class WorkPlanRespVM
    {
        public long WorkPlanId { get; set; }
        public long CPAId { get; set; }
        public string CPAName { get; set; }
        public long ClientId { get; set; }
        public string ClientName { get; set; }
        public long ProcessId { get; set; }
        public string ProcessName { get; set; }
        public long TaskId { get; set; }
        public string TaskName { get; set; }
        public decimal EstimatedDuration { get; set; }
        public decimal EstimatedProcessTime { get; set; }
        public long StatusId { get; set; }
        public string StatusName { get; set; }
        public long Quantity { get; set; }
        public decimal TotalTime { get; set; }
        public bool RecurringStatus { get; set; }
        public bool Event { get; set; }
        public int EventType { get; set; }
        public string EventDuration { get; set; }
        public string IsStop { get; set; }
    }

    public class WorkPlanListRespVM
    {
        public long WorkPlanId { get; set; }
        public DropdownItemVM CPA { get; set; }
        public DropdownItemVM Client { get; set; }
        public TaskListResp Process { get; set; }
        public TaskListResp Task { get; set; }
        public DropdownItemVM Status { get; set; }
        public long Quantity { get; set; }
        public bool RecurringStatus { get; set; }
        public bool Event { get; set; }
        public int EventType { get; set; }
        public string EventDuration { get; set; }
        public string IsStop { get; set; }
    }
    public class WorkPlanListWithCountVM
    {
        public bool IsBreak { get; set; }
        public long TotalCount { get; set; }
        public List<WorkPlanListRespVM> WorkPlanList { get; set; }

        public string TotalEventTime { get; set; }
        public string TotalBreakTime { get; set; }
    }

    public class CheckListVM
    {
        public long Id { get; set; }
        public long WorkPlanId { get; set; }
        public string Description { get; set; }
        public bool IsChecked { get; set; }
        public bool IsDeleted { get; set; }
    }
    public class CheckListResultVM
    {
        public long checkListId { get; set; }
    }

    public class checkListReqId
    {
        public long WorkPlanId { get; set; }
    }

    public class DeleteCheckList
    {
        public long CheckListId { get; set; }
    }

    public class WorkPlanComment : checkListReqId
    {
        public long Id { get; set; }
        public string Comment { get; set; }
        public bool IsComment { get; set; } = true;
    }

    public class CommentRespVM
    {
        public long CommentId { get; set; }
    }

    public class CommnetResponseVM : WorkPlanComment
    {
        public long CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CommentBy { get; set; }
        public string UserImage { get; set; }
    }

    public class WorkPlanCommentListWithCountVM
    {
        public long TotalCount { get; set; }
        public List<CommnetResponseVM> CommentList { get; set; }
    }

    public class SaveRecurringResp
    {
        public long RecurringId { get; set; }
    }
    public class RecurringVM : SaveRecurringResp
    {
        public long WorkPlanId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string RecurringCronExp { get; set; }
        public long? CreatedBy { get; set; }
    }

    public class RecurringWithCronExp : RecurringVM
    {
        public CropExpSep CropExpSepobj = new CropExpSep();
    }

    public class CropExpSep
    {
        public string Minutes { get; set; }
        public string Hours { get; set; }
        public string Days { get; set; }
        public string Months { get; set; }
        public string DayOfWeek { get; set; }
    }
}
