using System.ComponentModel.DataAnnotations.Schema;
using Forms_TechServ.classes.spareParts;

namespace Forms_TechServ.classes.batches
{
    [Table("BatchesSpareParts")]
    public class BatchSparePart
    {
        [Column("Id_Batch")] public int BatchId { get; set; }

        [Column("Id_Batch")] public Batch Batch { get; set; }

        [Column("Id_SparePart")] public int SparePartId { get; set; }

        [Column("Id_SparePart")] public SparePart SparePart { get; set; }

        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}