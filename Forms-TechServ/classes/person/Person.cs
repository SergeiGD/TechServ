using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Forms_TechServ.classes.person
{
    public abstract class Person 
    {
        [Column("Id")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNum { get; set; }
        public DateTime? DelTime { get; set; }

        
    }
}
