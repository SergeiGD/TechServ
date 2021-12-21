using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_TechServ
{
    [Table("OrdersSpareParts")]
    public class SparePartFromBatch
    {
        [Column("Id_Order")]
        public int OrderId { get; set; }
        [Column("Id_Order")]
        public Order Order { get; set; }

        [Column("Id_SparePart")]
        public int SparePartId { get; set; }
        [Column("Id_SparePart")]
        public SparePart SparePart { get; set; }

        [Column("Id_Batch")]
        public int BatchId { get; set; }
        [Column("Id_Batch")]
        public Batch Batch{ get; set; }

        [Column("Quantity")]
        public int Quantity { get; set; }
    }
}
