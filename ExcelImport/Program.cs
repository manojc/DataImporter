﻿using System;
using ExcelImport.Facade;

namespace ExcelImport
{
    class Program
    {

        public static void Main(string[] args)
        {
            var importer = new DataImporter();
            Console.WriteLine("Import started !");
            try
            {
                importer.ImportHotelDetails();
                importer.ImportRateDetails();
                importer.ImportHotelImages();
                importer.ImportHotelLocationDetails();
                importer.ImportHotelRatings();
                importer.ImportHotelNearBy();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            Console.WriteLine();
            Console.WriteLine("Import finished !");
        }
    }
}
