using System.ComponentModel.DataAnnotations.Schema;
using Forms_TechServ.classes.categories;

namespace Forms_TechServ.classes.employees
{
    /*public static class RoleStringExtensions
    {
        public static string GetRoleTypeString(this RoleType role)
        {
            switch (role)
            {
                case RoleType.Master:
                    return "Мастер";
                case RoleType.Manager:
                    return "Менеджер";
                case RoleType.Anyone:
                    return "Все";

                default:
                    return "Не определенно";
            }
        }

        public static RoleType GetRoleTypeEnum(string role)
        {
            switch (role)
            {
                case "Мастер":
                    return RoleType.Master;
                case "Менеджер":
                    return RoleType.Manager;
                case "Все":
                    return RoleType.Anyone;

                default:
                    return RoleType.Undefined;
            }
        }
    }*/

    [Table("MastersCategories")]
    public class MastersCategories
    {
        [Column("Id_Master")]
        public int MasterId { get; set; }
        [Column("Id_Master")]
        public Master Master { get; set; }

        [Column("Id_Category")]
        public int CategoryId { get; set; }
        [Column("Id_Category")]
        public Category Category { get; set; }
    }

}
