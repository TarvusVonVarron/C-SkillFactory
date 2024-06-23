using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Module9
{
    internal class Task2
    {
        public static void Run()
        {
            try
            {
                throw new ArgumentOutOfRangeException();
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                throw new RankException();
            }
            catch (RankException ex)
            {
                Console.WriteLine(ex.GetType());
            }
        }
    }
}
