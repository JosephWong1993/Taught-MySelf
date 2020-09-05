using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProcessMultipleExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Handing Muliple Exceptions *****\n");

            Car myCar = new Car("Rusty", 90);
            try
            {
                //触发超出范围异常
                myCar.Accelerate(-10);
            }
            catch (CarIsDeadException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                myCar.CrankTunes(false);
            }

            Console.ReadLine();
        }
    }
}
