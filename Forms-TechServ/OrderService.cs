using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_TechServ
{
    [Table("OrdersServices")]
    public class OrderService
    {
        [Column("Id_Order")]
        public int OrderId { get; set; }
        [Column("Id_Order")]
        public Order Order { get; set; }

        [Column("Id_Service")]
        public int ServiceId { get; set; }
        [Column("Id_Service")]
        public Service Service { get; set; }

        public int Quantity { get; set; }
        public decimal Price { get; set; }          // ХРАНИМ ЦЕНУ ЗА УСЛУГУ НА МОМЕНТ ДОБАВЛЕНИЯ В ЗАКАЗ, ЧТОБ ПРИ ИЗМЕНЕНИИ ЦЕН НА УСЛУГУ ВСЕ РАСЧИТЫВАЛОСЬ ПРИВИЛЬНО
        public decimal Sale { get; set; }
        public string MasterComment { get; set; }

        // ОКАЗАЛИ УЖЕ УСЛУГУ ИЛИ НЕТ ДЛЯ УДОБНОГО ПЛАНИРОВАНИЯ ВИЗИТОВ И ТАСКОВ МАСТЕРОВ
        public bool Done { get; set; }

        public decimal CalcFullPrice()
        {
            return this.Price * this.Quantity - (this.Price * this.Quantity * (this.Sale / 100));
        }
    }
}
