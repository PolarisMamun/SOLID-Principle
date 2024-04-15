using DIPDemo.Classes;
using DIPDemo.Interfaces;
using System;

namespace DIPDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            ICar proton = new Proton();
            ICar perodua = new Perodua();
            ICar honda = new Honda();
            ICar toyota = new Toyota();

            CarEngineStarter engineStarter = new CarEngineStarter(proton);
            engineStarter.StartYourEngine();
            engineStarter = new CarEngineStarter(perodua);
            engineStarter.StartYourEngine();
            engineStarter = new CarEngineStarter(honda);
            engineStarter.StartYourEngine();
            engineStarter = new CarEngineStarter(toyota);
            engineStarter.StartYourEngine();

            Console.ReadLine();
        }
    }
}
