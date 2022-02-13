using System.ComponentModel.DataAnnotations.Schema;
using Forms_TechServ.classes.batches;
using Forms_TechServ.classes.spareParts;

namespace Forms_TechServ.classes.orders
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
