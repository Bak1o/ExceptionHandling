using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Numerics;
namespace ExceptionHandling
{
    internal class Program
    {
        public static class Ensure
        {
            public static void Main(string[] args)
            {
               var product = new Product();
                product.Price = -100;
                product.Validate();

            }
            public static bool IsPositive<T>(T number)
                  where T : INumberBase<T>
            { if(T.IsPositive(number))
                return true;
                throw new Exception();
            }
            public static bool IsNegative<T>(T number)
                 where T : INumberBase<T>
            {
                return T.IsNegative(number);
            }
            public static bool IsNonPositive<T>(T number)
                where T : INumberBase<T>
            {
                return T.IsNegative(number);
            }
            public static bool IsNonNegative<T>(T number)
              where T : INumberBase<T>
            {
                return T.IsPositive(number);
            }
        }
        
    }


   //public static class Ensure
   // {
   //   public  static bool IsPositive<T>(T number)
   //         where T : INumberBase<T>
   //     {
   //         return T.IsPositive(number);
   //     }
   //    public static bool IsNegative<T>(T number)
   //         where T : INumberBase<T>
   //     {
   //         return T.IsNegative(number);
   //     }
   //    public static bool IsNonPositive<T>(T number)
   //        where T : INumberBase<T>
   //     {
   //         return T.IsNegative(number);
   //     }
   //     public static bool IsNonNegative<T>(T number)
   //       where T : INumberBase<T>
   //     {
   //         return T.IsPositive(number);
   //     }
   // }


 
}