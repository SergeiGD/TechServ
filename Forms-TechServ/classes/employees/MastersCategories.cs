using System.ComponentModel.DataAnnotations.Schema;
using Forms_TechServ.classes.categories;

namespace Forms_TechServ.classes.employees
{


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
