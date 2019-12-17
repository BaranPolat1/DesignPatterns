using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SinglePatterns
{
    class ThreadSafeSingleton
    {
        static object _lockObject = new object();

        
        
        private ThreadSafeSingleton()
        {

        }
        private static ThreadSafeSingleton _singleton2;

        public static ThreadSafeSingleton Olustur
        {
            get
            {
                lock (_lockObject)
                {
                    if (_singleton2 == null )
                    {
                        _singleton2 = new ThreadSafeSingleton();
                    }

                    
                }
                return _singleton2;

            }
        }
    }
}
