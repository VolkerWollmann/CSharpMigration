using System;
namespace ProgramNet50
{
    // C# 9.0 (.NET 5.0 )
    internal class ProgramNet50
    {
        static void Main(string[] args)
        {
            ;

            CS73NetFramework472NameSpace.CS73NetFramework472Class cs73NetFramework472Class = new CS73NetFramework472NameSpace.CS73NetFramework472Class();
            cs73NetFramework472Class.Method(1);

            CS73NetFramework480NameSpace.CS73NetFramework480Class cs73NetFramework480Class = new CS73NetFramework480NameSpace.CS73NetFramework480Class();
            cs73NetFramework472Class.Method(1);

            CS73Standard20NameSpace.CS73Standard20Class cs73Standard20Class = new CS73Standard20NameSpace.CS73Standard20Class();
            cs73Standard20Class.Method(1);

            CS80Standard21NameSpace.CS80Standard21Class cs80Standard21Class = new CS80Standard21NameSpace.CS80Standard21Class();
            cs80Standard21Class.Method(2);
            cs80Standard21Class.UseCS73Framework472SubClass();

            CS90Net50NameSpace.CS90Net50Class cs90Net50Class = new CS90Net50NameSpace.CS90Net50Class();
            cs90Net50Class.UseCS73Framework472SubClass();

        }
    }
}
