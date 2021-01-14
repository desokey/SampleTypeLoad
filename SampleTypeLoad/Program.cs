using Domain;
using ServiceLib;
using System;

namespace SampleTypeLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceManager manager = new ServiceManager();

            
            Type typeLoadedByServiceManager = manager.GetType();
            Console.WriteLine($"This is the AssemblyQualifiedName  when loaded through an intermediate layer { typeLoadedByServiceManager.AssemblyQualifiedName} ");


            Type typeLoadedByMe = typeof(MyCustomType);
            Console.WriteLine($"This is the AssemblyQualifiedName  when loaded through directtyly from me { typeLoadedByMe.AssemblyQualifiedName} ");

        }
    }
}
