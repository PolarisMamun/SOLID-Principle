using OrstedTest.Cars;
using System;

namespace OrstedTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Proton proton = new Proton();
            Perodua perodua = new Perodua();
            Honda honda = new Honda();
            Toyota toyota = new Toyota();

            CarEngineStart carengineStart = new CarEngineStart();

            carengineStart.StartYourEngine(proton);
            carengineStart.StartYourEngine(perodua);
            carengineStart.StartYourEngine(honda);
            carengineStart.StartYourEngine(toyota);

            Console.ReadLine();
        }       
    }
}
