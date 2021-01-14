using Domain;
using System;

namespace ServiceLib
{
    public class ServiceManager
    {

        public Type LoadType()
        {
           return  typeof(MyCustomType);
        }
    }
}
