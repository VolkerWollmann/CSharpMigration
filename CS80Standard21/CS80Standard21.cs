﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Threading.Tasks;

namespace CS80Standard21NameSpace
{
    public class CS80Standard21Class
    {
        // C# 9.0 (.NET 5.0 )
        public void Method(object o1)
        {
            //switch (o1)
            //{
            //    //case int: break; // test if o1 is an int
            //    //case System.String: break; // test if o1 is a string
            //}
        }

        // C# 7.3 (.NET Standard 2.0)
        public void DB()
        {
            SqlCommand sqlCommand = new SqlCommand();
        }

        //C# 8.0 (.NET Standard 2.1)
        public static async IAsyncEnumerable<int> e()
        {
            for (int i = 1; i <= 10; i++)
            {
                await Task.Delay(1000);//Simulate waiting for data to come through. 
                yield return i;
            }
        }
        public void UseSubClass()
        {
            C73Standard20SubClassNameSpace.CS73Standard20SubClass.Method1();
        }

        public void UseCS73Framework472SubClass()
        {
            CS73Framework472SubClassNameSpace.CS73Framework472SubClass.Method1();
        }

        // C# 8.0 (.NET Standard 2.1) : no remoting
        //public void UseRemoting()
        //{
        //    ObjectHandle objectHandle = null;
        //}
    }
}
