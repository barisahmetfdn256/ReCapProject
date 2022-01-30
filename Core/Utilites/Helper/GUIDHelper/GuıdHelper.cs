using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilites.Helper.GUIDHelper
{
    public class GuidHelper
    {
       public  static string CreateGuid()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
