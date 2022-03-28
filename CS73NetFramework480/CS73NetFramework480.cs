﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Threading.Tasks;

namespace CS80Standard21NameSpace
{
    //  https://docs.microsoft.com/de-de/dotnet/framework/migration-guide/runtime/4.7.2-4.8
    public class CS73Standard21Class
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

        // C# 8.0 (.NET Standard 2.1)
        //public static async IAsyncEnumerable<int> e()
        //{
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        await Task.Delay(1000);//Simulate waiting for data to come through. 
        //        yield return i;
        //    }
        //}
    }
}