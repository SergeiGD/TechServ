using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_TechServ
{
    public abstract class Person //: IComparable<Person>
    {
        [Column("Id")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNum { get; set; }
        public DateTime? DelTime { get; set; }

        
    }
}
