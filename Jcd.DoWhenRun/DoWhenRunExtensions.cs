using System;
using System.Collections;
using System.Collections.Generic;

namespace Jcd.DoWhenRun
{
    /// <summary>
    /// A netstandard 1.0 set of extension methods, Do, DoWhen and Run, that give a `Fluent`
    /// builder-pattern-like experience to operating on `IEnumerable` and `IEnumerable&lt;T&gt;` 
    /// derived types.
    /// </summary>
    public static class DoWhenRunExtensions 
    {
        /// <summary>
        /// Setup an action to conditionally run across the elements of a collection/enumerable.
        /// </summary>
        /// <param name="enumerable">The collection to scan</param>
        /// <param name="action">The action to perform on each element and index of the element.</param>
        /// <param name="predicate">The condition to check. If true, performs the action.</param>
        /// <returns>The elements from the input sequence</returns>
        /// <remarks>This is a LINQ compatible visitor pattern</remarks>
        public static IEnumerable DoWhen(this IEnumerable enumerable, Func<object, bool> predicate, Action<int,object> action)
        {
            return enumerable.DoWhen((_, item) => predicate(item), action);
        }

        /// <summary>
        /// Setup an action to conditionally run across the elements of a collection/enumerable.
        /// </summary>
        /// <param name="enumerable">The collection to scan</param>
        /// <param name="action">The action to perform on each element and index of the element.</param>
        /// <param name="predicate">The condition to check. If true, performs the action.</param>
        /// <returns>The elements from the input sequence</returns>
        /// <remarks>This is a LINQ compatible visitor pattern</remarks>
        public static IEnumerable DoWhen(this IEnumerable enumerable, Func<object, bool> predicate, Action<object> action)
        {
            return enumerable.DoWhen((_, item) => predicate(item), (_, item) => action(item));
        }

        /// <summary>
        /// Setup an action to conditionally run across the elements of a collection/enumerable.
        /// </summary>
        /// <param name="enumerable">The collection to scan</param>
        /// <param name="action">The action to perform on each element and index of the element.</param>
        /// <param name="predicate">The condition to check. If true, performs the action.</param>
        /// <returns>The elements from the input sequence</returns>
        /// <remarks>This is a LINQ compatible visitor pattern</remarks>
        public static IEnumerable DoWhen(this IEnumerable enumerable, Func<int,object,bool> predicate, Action<int,object> action)
        {
            var index = 0;
            foreach (var item in enumerable)
            {
                if (predicate.Invoke(index, item)) action?.Invoke(index,item);
                yield return item;
                index++;
            }
        }
        
        /// <summary>
        /// Setup an action to conditionally run across the elements of a collection/enumerable.
        /// </summary>
        /// <param name="enumerable">The collection to scan</param>
        /// <param name="action">The action to perform on each element and index of the element.</param>
        /// <param name="predicate">The condition to check. If true, performs the action.</param>
        /// <typeparam name="T">The type of each element</typeparam>
        /// <returns>The elements from the input sequence</returns>
        /// <remarks>This is a LINQ compatible visitor pattern</remarks>
        public static IEnumerable<T> DoWhen<T>(this IEnumerable<T> enumerable, Func<T, bool> predicate, Action<int,T> action)
        {
            return enumerable.DoWhen((_, item) => predicate(item), action);
        }

        /// <summary>
        /// Setup an action to conditionally run across the elements of a collection/enumerable.
        /// </summary>
        /// <param name="enumerable">The collection to scan</param>
        /// <param name="action">The action to perform on each element and index of the element.</param>
        /// <param name="predicate">The condition to check. If true, performs the action.</param>
        /// <typeparam name="T">The type of each element</typeparam>
        /// <returns>The elements from the input sequence</returns>
        /// <remarks>This is a LINQ compatible visitor pattern</remarks>
        public static IEnumerable<T> DoWhen<T>(this IEnumerable<T> enumerable, Func<T, bool> predicate, Action<T> action)
        {
            return enumerable.DoWhen((_, item) => predicate(item), (_, item) => action(item));
        }

        /// <summary>
        /// Setup an action to conditionally run across the elements of a collection/enumerable.
        /// </summary>
        /// <param name="enumerable">The collection to scan</param>
        /// <param name="action">The action to perform on each element and index of the element.</param>
        /// <param name="predicate">The condition to check. If true, performs the action.</param>
        /// <typeparam name="T">The type of each element</typeparam>
        /// <returns>The elements from the input sequence</returns>
        /// <remarks>This is a LINQ compatible visitor pattern</remarks>
        public static IEnumerable<T> DoWhen<T>(this IEnumerable<T> enumerable, Func<int,T,bool> predicate, Action<int,T> action)
        {
            var index = 0;
            foreach (var item in enumerable)
            {
                if (predicate.Invoke(index, item)) action?.Invoke(index,item);
                yield return item;
                index++;
            }
        }
        
        /// <summary>
        /// Setup an action to run across the elements of a collection/enumerable.
        /// </summary>
        /// <param name="enumerable">The collection to scan</param>
        /// <param name="action">The action to perform on each element and index of the element.</param>
        /// <typeparam name="T">The type of each element</typeparam>
        /// <returns>The elements from the input sequence</returns>
        /// <remarks>This is a LINQ compatible visitor pattern</remarks>
        public static IEnumerable<T> Do<T>(this IEnumerable<T> enumerable, Action<int,T> action)
        {
            var index = 0;
            foreach (var item in enumerable)
            {
                action?.Invoke(index,item);
                yield return item;
                index++;
            }
        }
        
        /// <summary>
        /// Setup an action to run across the elements of a collection/enumerable.
        /// </summary>
        /// <param name="enumerable">The collection to scan</param>
        /// <param name="action">The action to perform on each element.</param>
        /// <typeparam name="T">The type of each element</typeparam>
        /// <returns>The elements from the input sequence</returns>
        /// <remarks>This is a LINQ compatible visitor pattern</remarks>
        public static IEnumerable<T> Do<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            return enumerable.Do((_, t) => action.Invoke(t));
        }

        /// <summary>
        /// Setup an action to run across the elements of a collection/enumerable.
        /// </summary>
        /// <param name="enumerable">The collection to scan</param>
        /// <param name="action">The action to perform on each element.</param>
        /// <returns>The elements from the input sequence</returns>
        /// <remarks>This is a LINQ compatible visitor pattern</remarks>
        public static IEnumerable Do(this IEnumerable enumerable, Action<int,object> action)
        {
            var index = 0;
            foreach (var item in enumerable)
            {
                action?.Invoke(index,item);
                yield return item;
                index++;
            }
        }

        /// <summary>
        /// Setup an action to run across the elements of a collection/enumerable.
        /// </summary>
        /// <param name="enumerable">The collection to scan</param>
        /// <param name="action">The action to perform on each element.</param>
        /// <returns>The elements from the input sequence</returns>
        /// <remarks>This is a LINQ compatible visitor pattern</remarks>
        public static IEnumerable Do(this IEnumerable enumerable, Action<object> action)
        {
            return enumerable.Do((_, t) => action.Invoke(t));
        }

        /// <summary>
        /// Forces enumeration of an enumerable. 
        /// </summary>
        /// <param name="enumerable">The enumerable to force enumeration on</param>
        /// <typeparam name="T">The type of each element in the enumeration.</typeparam>
        /// <remarks>
        /// Called solely on the likes of a List or Array this is a useless method.
        /// But combined with LINQ extensions and Scan this enables setting
        /// up easier to read code that performs operations on the elements
        /// within a collection, possibly filtered, or otherwise altered via LINQ.
        /// Coercing the enumeration then executes all of the Scan blocks, as appropriate.
        /// This then causes execution of the visitor pattern configured by calls to Scan.
        /// CAUTION: Do not use on a LINQ-to-SQL or similar enumerable. Results are undefined,
        /// and probably undesirable.
        /// </remarks>
        public static void Run<T>(this IEnumerable<T> enumerable)
        {
            foreach (var unused in enumerable) { }
        }

        /// <summary>
        /// Forces enumeration of an enumerable. 
        /// </summary>
        /// <param name="enumerable">The enumerable to force enumeration on</param>
        /// <remarks>
        /// Called solely on the likes of a List or Array this is a useless method.
        /// But combined with LINQ extensions and Scan this enables setting
        /// up easier to read code that performs operations on the elements
        /// within a collection, possibly filtered, or otherwise altered via LINQ.
        /// Coercing the enumeration then executes all of the Scan blocks, as appropriate.
        /// This then causes execution of the visitor pattern configured by calls to Scan.
        /// CAUTION: Do not use on a LINQ-to-SQL or similar enumerable. Results are undefined,
        /// and probably undesirable.
        /// </remarks>
        public static void Run(this IEnumerable enumerable)
        {
            foreach (var unused in enumerable) { }
        }
    }
}