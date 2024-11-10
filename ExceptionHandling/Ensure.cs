using System.Numerics;
namespace ExceptionHandling
{
   
        public static class Ensure
        {
           
            public static bool IsPositive<T>(T number)
                  where T : INumberBase<T>
            {
              if( T.IsPositive(number))
                return true;
            throw new Exception(" id must be positive ");

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
            if (T.IsPositive(number))
                return true;
            throw new Exception(" Price value must be positive ");
        }
        public static bool IsNotNullOrEmpty(string str)
        {
            if (string.IsNullOrEmpty(str))
                throw new Exception(" Name value must not be empty or null ");
            return true;
        }
        public static bool IsNotNullOrWhiteSpace(string str)
        {
            if (string.IsNullOrEmpty(str))
                throw new Exception(" Manufacturer value must not be empty or null ");
            return true;
        }
        public static bool IsInRange<T>(T number, T lowerbound, T upperbound)
            where T : INumber<T>
        {
            if(lowerbound < number && number < upperbound && T.IsPositive(number) )
            {
                return true;

            }
            throw new Exception($" the rating value must be between {lowerbound} to {upperbound} ");

        }
        }
        
    


  


 
}