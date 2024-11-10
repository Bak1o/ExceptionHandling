using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
namespace ExceptionHandling
{
    internal partial class Program
    {
        public static void Main(string[] args)
        {
            try
            {
               var productService = new ProductService();
                var product = productService.GetProduct();
                
                
            }
            catch (FormatException )
            {
                Console.WriteLine("Formatexception");
            }
            catch (OverflowException )
            {
                Console.WriteLine(" overflow exception");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
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