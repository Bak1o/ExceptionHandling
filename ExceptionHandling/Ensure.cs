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
                if( T.IsNegative(number))
                return true;
            throw new Exception("number value must be negative ");
            }
            public static bool IsNonPositive<T>(T number)
                where T : INumberBase<T>
            {
            if (T.IsNegative(number))
                return true;
            throw new Exception("number value must be negative ");
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
            if (string.IsNullOrEmpty(str)|| string.IsNullOrWhiteSpace(str))
                throw new Exception(" Manufacturer value must not be empty or null ");
            return true;
        }

        public static bool IsNotEmpty(string str)
        {
            if (str.Equals(""))
                throw new Exception(" string value must not be empty ");
            return true;
        }

        public static bool IsNotNull(string str)
        {
            if (str == null)
                throw new Exception(" string value must not be null ");
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
        public static bool IsNotInRange<T>(T number, T lowerbound, T upperbound)
           where T : INumber<T>
        {
            if (lowerbound < number && number < upperbound)
            {
                throw new Exception($" the rating value must not be between {lowerbound} to {upperbound} ");

            }
            return true;

        }
        public static bool IsGreaterThan<T>(T number1, T number2)
            where T : INumber<T>
        {
            if (number1 > number2)
            
                return true;
            throw new Exception(" first number is not greater than second number ");
            
        }

        public static bool IsGreaterThanOrEqual<T>(T number1, T number2)
           where T : INumber<T>
        {
            if (number1 >= number2)

                return true;
            throw new Exception(" first number is not greater than or equal to second number ");

        }
        public static bool IsLessThan<T>(T number1, T number2)
           where T : INumber<T>
        {
            if (number1 < number2)

                return true;
            throw new Exception(" first number is not Less than second number ");

        }
        public static bool IsLessThanOrEqual<T>(T number1, T number2)
          where T : INumber<T>
        {
            if (number1 <= number2)

                return true;
            throw new Exception(" first number is not less than or equal to second number ");

        }
    }
        
    


  


 
}