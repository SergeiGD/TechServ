using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_TechServ
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
