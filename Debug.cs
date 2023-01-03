using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiaHan.Tools;
public static class Debug
{
    public static void Dump<T>(this T t) => Console.WriteLine(t);

    public static void Dump<T>(this IEnumerable<T> elements)
    { 
        foreach (var element in elements)
        {
            Console.WriteLine(element);
        }
    }
}
