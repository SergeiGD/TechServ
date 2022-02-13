using System.ComponentModel.DataAnnotations.Schema;
using Forms_TechServ.classes.services;

namespace Forms_TechServ.classes.visits
{
    [Table("VisitsServices")]
    public class VisitService
    {
        [Column("Id_Visit")]
        public int VisitId { get; set; }
        [Column("Id_Visit")]
        public Visit Visit { get; set; }

        [Column("Id_Service")]
        public int ServiceId { get; set; }
        [Column("Id_Service")]
        public Service Service { get; set; }
    }
}
