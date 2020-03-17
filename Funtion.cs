using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.DesignScript.Runtime;

namespace DynamoUI
{
    [IsVisibleInDynamoLibrary(false)]
    public class SampleFuntion
    {
        public static double MultiplyTwoNumbers(double a, double b)
        {
            return a * b;
        }
    }
}
