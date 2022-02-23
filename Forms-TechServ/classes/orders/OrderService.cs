using System.ComponentModel.DataAnnotations.Schema;
using Forms_TechServ.classes.services;

namespace Forms_TechServ.classes.orders
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

        
        public bool Done { get; set; }              // ОКАЗАЛИ УЖЕ УСЛУГУ ИЛИ НЕТ ДЛЯ УДОБНОГО ПЛАНИРОВАНИЯ ВИЗИТОВ И ТАСКОВ МАСТЕРОВ

        public decimal CalcFullPrice()
        {
            return this.Price * this.Quantity - (this.Price * this.Quantity * (this.Sale / 100));
        }
    }
}
