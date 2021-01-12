using MediatR.MediatR_Custom;
using System;

namespace MediatRExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //MediatR - Custom implementationm

            MediatRImplementation obj = new MediatRImplementation();

            var channel1 = new MediatorRChannel1(obj);
            var channel2 = new MediatorRChannel2(obj);

            obj.SetChannel1 = channel1;
            obj.SetChannel2 = channel2;

            channel1.Send("Hello from channel-1");
            channel2.Send("Hi from channel-2");

            Console.ReadKey();
        }
    }
}
