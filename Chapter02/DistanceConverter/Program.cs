﻿using System;
using System.Security.Cryptography.X509Certificates;

namespace DistanceConverter {
    internal class Program {
        static void Main(string[] args) {
            if (args.Length >= 1 && args[0] == "-tom") { 
                PrintFeetToMeterList(int.Parse(args[1]), int.Parse(args[2]));
            } else {
                PrintMeterToFeetList(int.Parse(args[1]), int.Parse(args[2]));
            }
        }

        //フィートからメートルへの対応表を出力
        static void PrintFeetToMeterList(int start, int stop) {
            FeetConverter fc = new FeetConverter();
            for (int feet = start; feet <= stop; feet++) {
                double meter = fc.ToFeet(feet);
                Console.WriteLine("{0}ft = {1:0.0000} m", feet, meter);
            }
        }

        //メートルからフィートへの対応表を出力
        static void PrintMeterToFeetList(int start, int stop) {
            FeetConverter fc= new FeetConverter();
            for (int meter = start; meter <= stop; meter++) {
                double feet = fc.FromMeter(meter);
                Console.WriteLine("{0}m = {1:0.0000} ft", meter, feet);
            }
        }
    }
}
