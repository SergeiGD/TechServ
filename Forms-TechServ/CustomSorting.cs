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

        /*public static IEnumerable<T> SortBy<T>(this IEnumerable<T> source, string propName, bool desk)
        {
            ParameterExpression param = ParameterExpression.Parameter(typeof(T), "p");              // параметр лямбды

            string askdesk = desk ? "OrderByDescending" : "OrderBy";                                // как сортировать
            var method = typeof(Enumerable).GetMethods(BindingFlags.Public | BindingFlags.Static).Where(m => m.Name == askdesk && m.GetParameters().Count() == 2).First();      // ищем метод OrderBy/OrderByDesk

            if (propName.Contains("()"))
            {
                // ЕСЛИ СОРТИРОВКА ПО МЕТОДУ ОБЪЕКТА
                var getMeth = typeof(T).GetMethods().Where(m => m.Name == propName.Substring(0, propName.Length - 2) && m.GetParameters().Count() == 0).First();      // ИЩЕМ НУЖНЫЙ МЕТОД
                method = method.MakeGenericMethod(typeof(T), getMeth.ReturnType);                   // типизируем
                var methodExp = Expression.Call(param, getMeth);
                var result = method.Invoke(null, new object[] { source, Expression.Lambda(methodExp, param).Compile() });   // null т.к. статик метод

                return (IEnumerable<T>)result;
            }
            else
            {
                // ЕСЛИ СОРТИРОВКА ПО СВОЙСТВУ ОБЪЕКТА
                var propExp = Expression.Property(param, propName);                                 // ИЩЕМ НУЖНОЕ СВОЙСТВО
                method = method.MakeGenericMethod(typeof(T), propExp.Type);                         // типизируем
                var result = method.Invoke(null, new object[] { source, Expression.Lambda(propExp, param).Compile() });     // null т.к. статик метод

                return (IEnumerable<T>)result;
            }

        }*/

        public static IEnumerable<T> SortBy<T>(this IEnumerable<T> source, string propName, bool desk, object methodParam = null)
        {
            ParameterExpression param = ParameterExpression.Parameter(typeof(T), "p");              // параметр лямбды

            string askdesk = desk ? "OrderByDescending" : "OrderBy";                                // как сортировать
            var method = typeof(Enumerable).GetMethods(BindingFlags.Public | BindingFlags.Static).Where(m => m.Name == askdesk && m.GetParameters().Count() == 2).First();      // ищем метод OrderBy/OrderByDesk

            if (propName.Contains("()"))
            {
                // ЕСЛИ СОРТИРОВКА ПО МЕТОДУ ОБЪЕКТА
                if (methodParam != null)
                {
                    // ЕСЛИ С ПАРАМЕТРОМ
                    var getMeth = typeof(T).GetMethods().Where(m => m.Name == propName.Substring(0, propName.Length - 2) && m.GetParameters().Count() == 1).First();      // ИЩЕМ НУЖНЫЙ МЕТОД
                    method = method.MakeGenericMethod(typeof(T), getMeth.ReturnType);                   // типизируем
                    var methodExp = Expression.Call(param, getMeth, Expression.Constant(methodParam));
                    var result = method.Invoke(null, new object[] { source, Expression.Lambda(methodExp, param).Compile() });   // null т.к. статик метод

                    return (IEnumerable<T>)result;
                }
                else
                {
                    // ЕСЛИ БЕЗ ПАРАМЕТРОВ
                    var getMeth = typeof(T).GetMethods().Where(m => m.Name == propName.Substring(0, propName.Length - 2) && m.GetParameters().Count() == 0).First();      // ИЩЕМ НУЖНЫЙ МЕТОД
                    method = method.MakeGenericMethod(typeof(T), getMeth.ReturnType);                   // типизируем
                    var methodExp = Expression.Call(param, getMeth);
                    var result = method.Invoke(null, new object[] { source, Expression.Lambda(methodExp, param).Compile() });   // null т.к. статик метод

                    return (IEnumerable<T>)result;
                }
                
            }
            else
            {
                // ЕСЛИ СОРТИРОВКА ПО СВОЙСТВУ ОБЪЕКТА
                var propExp = Expression.Property(param, propName);                                 // ИЩЕМ НУЖНОЕ СВОЙСТВО
                method = method.MakeGenericMethod(typeof(T), propExp.Type);                         // типизируем
                var result = method.Invoke(null, new object[] { source, Expression.Lambda(propExp, param).Compile() });     // null т.к. статик метод

                return (IEnumerable<T>)result;
            }

        }
    }
}
