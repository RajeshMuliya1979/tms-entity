namespace TMS.Entity
{
    public class UserIdVM
    {
        public long UserId { get; set; }
    }

    public class UserBasicDetailVM
    {
        public long UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public bool IsEmailVerified { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public string Password { get; set; }
    }

    public class UserVM : UserBasicDetailVM
    {
        public List<long> RoleTypeIds { get; set; } = new List<long>();
        public List<long> OrganizationIds { get; set; } = new List<long>();
        public long ParentId { get; set; }
        public string MobileNo { get; set; }
        public long DepartmentId { get; set; }
        public string ProfileImage { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public long UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public List<string> RoleName { get; set; }
    }

    public class UserListFilterVM : PageFilterVM
    {
        public long? RoleTypeId { get; set; }
        public long? DepartmentId { get; set; }
        public long? UserId { get; set; }
    }

    public class CommonUserItemDataVM
    {
        public long UserId { get; set; }
        public long ParentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string MobileNo { get; set; }
        public bool IsActive { get; set; }
    }

    public class UserItemDataVM : CommonUserItemDataVM
    {
        public string Organizations { get; set; }
        public string Roles { get; set; }
        public long DepartmentId { get; set; }
        public string DepartmentName { get; set; }
    }

    public class UserListItemVM : CommonUserItemDataVM
    {
        public DropdownItemVM DepartmentType { get; set; }
        public List<DropdownItemVM> Organizations { get; set; } = new List<DropdownItemVM>();
        public List<DropdownItemVM> Roles { get; set; } = new List<DropdownItemVM>();
    }

    public class UserListVM : DataListVM<UserListItemVM>
    {

    }

    public enum RoleTypes
    {
        SuperAdmin = 1,
        Admin = 2
    }

    public class UserOrganizationVM : DataItemFieldsVM
    {
        public long UserOrganizationId { get; set; }
        public long UserId { get; set;}
        public long OrganizationId { get; set; }
    }

    public class UserRoleTypeVM : DataItemFieldsVM
    {
        public long UserRoleTypeId { get; set; }
        public long UserId { get; set; }
        public long RoleTypeId { get; set; }
        public string RoleName { get; set; }
    }
}
