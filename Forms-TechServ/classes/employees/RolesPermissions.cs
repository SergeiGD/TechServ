using System.ComponentModel.DataAnnotations.Schema;

namespace Forms_TechServ.classes.employees
{
    [Table("RolesPermissions")]
    public class RolesPermissions
    {
        [Column("Id_Role")]
        public int RoleId { get; set; }
        [Column("Id_Role")]
        public Role Role { get; set; }

        [Column("Id_Permission")]
        public int PermissionId { get; set; }
        [Column("Id_Permission")]
        public Permission Permission { get; set; }
    }
}