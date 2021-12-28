using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_TechServ
{
    // КЛАСС ДЛЯ ПЕРЕДАЧЕ ДАННЫХ ПО ССЫЛКЕ (ДЛЯ РАСПИШЕННОГО ФИЛЬТРА СОРТИРОВКИ ЗАКАЗОВ)
    public class ValueWrapper<T>
    {
        public T Value { get; set; }
        public ValueWrapper(T value) { this.Value = value; }
    }
}
