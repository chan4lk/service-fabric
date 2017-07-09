using System;
using Microsoft.ServiceFabric.Services.Remoting.Client;

using System.Threading;
using CalculatorApplication.Contracts;

namespace CalculatorClient
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var calculatorClient = ServiceProxy.Create<ICalculatorService>(new
                Uri("fabric:/CalculatorApplication/CalculatorService"));
                var result = calculatorClient.Add(1, 2).Result;
                Console.WriteLine(result);
                Thread.Sleep(3000);
            }            
        }
    }
}
