using System;
using Dynamo.Graph.Nodes;

namespace DynamoUI.Funtion
{
    [NodeName("UI.MultiplyTwoNumbers")]
    public static class SampleFuntion
    {
        public static double MultiplyTwoNumbers(double a, double b)
        {
            return a * b;
        }
    }
}