using System;
using System.Linq;
using System.Reflection;

namespace Jcd.DoWhenRun.Examples
{
    internal static class Program
    {
        private static void Main(string[] args)
        {

            // execute some code on each tuple during enumeration.
            (from x in Enumerable.Range(0, 4)
             from y in Enumerable.Range(0, 4)
             select (x, y))
                .DoWhen((i,_)=>i > 0 && i % 4 == 0, (_,_)=>Console.WriteLine())
                .Do(t=>Console.Write(t))
                .Run();

            Console.WriteLine();
            
            // The standard foreach method            
            var tuples = (from x in Enumerable.Range(0, 4)
                          from y in Enumerable.Range(0, 4)
                          select (x, y));
            var i = 0;
            foreach (var t in tuples)
            {
                if ( i > 0 && i % 4 == 0 ) Console.WriteLine();
                Console.Write(t);
                i++;
            }
            Console.WriteLine();


            var moretuples = (from x in Enumerable.Range(0, 4)
                              from y in Enumerable.Range(0, 4)
                              select (x, y))
                .DoWhen((i, _) => i > 0 && i % 4 == 0, (_, _) => Console.WriteLine())
                .Do(t =>
                {
                    Console.Write(t); // log each time this is visited during a subsequent enumeration.
                });

            var evenMoreTuples = moretuples.Do((_, _) => Console.Write(" Added behavior "));
            Console.WriteLine();
            Console.WriteLine();
            foreach (var t in moretuples)
            {
                // pretend to do some math with the tuple. but really spit out x.
                Console.Write($"[x={t.y}] ");
            }
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Pretend to do something else");
            
            foreach (var t in evenMoreTuples)
            {
                // pretend to do some math with the tuple. but really spit out y.
                Console.Write($"[y={t.y}] ");
            }
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Notice how the tuples were output twice. This means we've re-enumerated the collection. This is a bad thing."+
            " By injecting a visitor we can see it happen. Of Course visitors can have other functions too"+
            "\r\n\r\nWARNING: Visitors with side-effects, such as Console output, can cause unexpected behavior, as witnessed in this example, use with care!");

            
            AppDomain.CurrentDomain.GetAssemblies()
                .Do(assembly =>
                {
                    Console.WriteLine("A:" + assembly);
                    assembly.Modules.Do(module =>
                        {
                            Console.WriteLine("  MOD:" + module);
                            module.CustomAttributes.Do(attr => { Console.WriteLine("    ATTR:" + attr); }).Run();
                            module.GetMethods().Do(method => { Console.WriteLine("    M:" + method); }).Run();
                        }).Run();
                })
                // only output detailed type info on Assemblies starting with "Jcd."
                .Where(assembly => assembly.GetName().Name?.StartsWith("Jcd.") ?? false)
                .Do(assembly => assembly.DefinedTypes.Do(type =>
                    {
                        Console.WriteLine("    T:"+type);
                        type.GetProperties(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).Do(propertyInfo => { Console.WriteLine("        PI:" + propertyInfo); })
                            .Run();
                        type.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).Do(fieldInfo => { Console.WriteLine("        FI:" + fieldInfo); })
                            .Run();
                        type.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).Do(method =>
                            {
                                Console.WriteLine("        MI:" + method);
                                method.GetParameters().Do(param => { Console.WriteLine("            PARAM:" + param); }).Run();
                            })
                            .Run();
                    }).Run()
                ).Run();
         }
    }
}
