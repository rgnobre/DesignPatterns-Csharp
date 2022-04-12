﻿using System;

namespace BridgePattern
{
    public class Program
    {
        public static void Main()
        {
            DateTime now = DateTime.Now;

            var license1 = new MovieLicense("Secret Life of Pets", now, Discount.None, LicenceType.LifeLong);
            var license2 = new MovieLicense("Matrix", now, Discount.None, LicenceType.TwoDays);

            PrintLicenseDetails(license1);
            PrintLicenseDetails(license2);

            var license3 = new MovieLicense("Secret Life of Pets", now, Discount.Military, LicenceType.TwoDays);
            var license4 = new MovieLicense("Matrix", now, Discount.Military, LicenceType.LifeLong);

            PrintLicenseDetails(license3);
            PrintLicenseDetails(license4);

            var license5 = new MovieLicense("Secret Life of Pets", now, Discount.Senior, LicenceType.LifeLong);
            var license6 = new MovieLicense("Matrix", now, Discount.Senior, LicenceType.LifeLong);

            PrintLicenseDetails(license5);
            PrintLicenseDetails(license6);

            Console.ReadKey();
        }

        private static void PrintLicenseDetails(MovieLicense license)
        {
            Console.WriteLine($"Movie: {license.Movie}");
            Console.WriteLine($"Price: {GetPrice(license)}");
            Console.WriteLine($"Valid for: {GetValidFor(license)}");

            Console.WriteLine();
        }

        private static string GetPrice(MovieLicense license)
        {
            return $"${license.GetPrice():0.00}";
        }

        private static string GetValidFor(MovieLicense license)
        {
            DateTime? expirationDate = license.GetExpirationDate();

            if (expirationDate == null)
                return "Forever";

            TimeSpan timeSpan = expirationDate.Value - DateTime.Now;

            return $"{timeSpan.Days}d {timeSpan.Hours}h {timeSpan.Minutes}m";
        }
    }
}