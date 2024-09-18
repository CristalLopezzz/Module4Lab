// See https://aka.ms/new-console-template for more information
//Applpication Name: Rocket Launch
//Developer: Cristal Lopez
//Decription: Simulates a rocket launch using loops

using System;
using System.Threading;

namespace RocketLaunchApp{
    class Program {
        

        static void Main(string[] args) {
            Console.WriteLine("Welcome to Rocket Countdown!");
            Console.WriteLine("Get ready for liftoff!");

            for (int i = 10; i > 0; i--)
            {
                //Show the current place in the countdown to the user
                Console.WriteLine($"T-{i} seconds...");

                //wait for 1 second
                Thread.Sleep(1000);
            } //end for loop

            //Start the ignition sequence
            Console.WriteLine("Ignition sequence start!");
            Console.WriteLine("Engines are firing...");

            //Countdown using a while loop
            int countdown = 5;
            while(countdown > 0){
                //Output the number of seconds for the liftoff
                Console.WriteLine($"T-{countdown} seconds...");
                Thread.Sleep(1000); //Wait for 1 second

                //Decrement the countdown variable 
                countdown --;
            } //End while loop

             //Liftoff
             Console.WriteLine("Liftoff! The rocket is on its way to space!");
             Console.WriteLine("Mission accomplished. Have a stellar day!");

             //Simulate the rocket ascent
             for (int altitude = 0; altitude <= 100; altitude += 10){
                Console.WriteLine($"Altitude: {altitude} km");
                Thread.Sleep(500); //Wait for half of a second
             } //end for loop

        } //end main method
    } //end Program cclass

} //end namespace