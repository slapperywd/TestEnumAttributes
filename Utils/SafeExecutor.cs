using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEnumAttributes.Utils
{
    public class SafeExecutor
    {
        public static void Execute(Action action)
        {
            try
            {
                action();
            }
            catch (Exception e) { }
        }

        public static T Execute<T>(Func<T> action)
        {
            try
            {
                return action();

            }
            catch (Exception e)
            {
                return default(T);
            }
        }
    }
}
