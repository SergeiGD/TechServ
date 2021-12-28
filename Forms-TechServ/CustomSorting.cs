using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Forms_TechServ
{
    public static class CustomSorting
    {
        public static IEnumerable<T> SortBy<T>(this IEnumerable<T> source, string propName, bool desk)
        {
            ParameterExpression param = ParameterExpression.Parameter(typeof(T), "p");              // параметр лямбды
            Expression getProp = Expression.Property(param, propName);                              // получить свойство
            
            var experRes = Expression.Lambda(getProp, param);

            string askdesk = desk ? "OrderByDescending" : "OrderBy";                                // как сортировать
            var method = typeof(Enumerable).GetMethods(BindingFlags.Public | BindingFlags.Static).Where(m => m.Name == askdesk && m.GetParameters().Count() == 2).First();      // ищем метод OrderBy/OrderByDesk
            method = method.MakeGenericMethod(typeof(T), getProp.Type);                             // типизируем

            var result = method.Invoke(null, new object[] { source, experRes.Compile() });          // вызываем метод, null т.к. статик

            return (IEnumerable<T>)result;
            
        }
    }
}
