namespace Forms_TechServ.classes.helpers
{
    // КЛАСС ДЛЯ ПЕРЕДАЧЕ ДАННЫХ ПО ССЫЛКЕ (ДЛЯ РАСПИШЕННОГО ФИЛЬТРА СОРТИРОВКИ ЗАКАЗОВ)
    public class ValueWrapper<T>
    {
        public T Value { get; set; }
        public ValueWrapper(T value) { this.Value = value; }
    }
}
