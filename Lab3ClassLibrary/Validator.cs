//Lab3 description
// Create Windows Forms application called "ProductMaintenance" that lets the user maintain products.
// The application consists of two forms "ProductMaintenance" and "Add+Modify Products".
// This file present the code wirtten for Validation of data entered by user on "AddProducts" form.
// Ceti Zyko, 05May2021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
        public static class Validator // constructor
        {
            public static string LineEnd { get; set; } = "\n";

        // User input data is validated: Product Code
        public static string IsPresent(string value, string name) // Validation method
        {
            string msg = "";
            if (value == "") // Check if text box entry is empty or more than 10 characters
            {
                msg += name + " is a required field." + LineEnd;
            }
            return msg;
        }

        // User input data is validated: Prodect Name
        public static string IsMoreThanNumber(string value, string name, int num) // Validation method
        {
            string msg = "";
            if (value.Length > num) // Check if text box entry is more than 50 characters
            {
                msg += name + $" should be less than {num} characters." + LineEnd;
            }
            return msg;
        }

        // User input data is validated: Part #1 - Version, Decimal entry
        public static string IsDecimal(string value, string name) // Validation method
        {
            string msg = "";
            if (!Decimal.TryParse(value, out _)) // Check if data entry is decimal
            {
                msg += name + " must be a valid decimal value." + LineEnd;
            }
            return msg;
        }

        // User input data is validated: Part #2 - Version, Decimal Length entry
        public static string IsDecimcalLength(string value, string name) // Validation method
        {
            string msg = "";
            // checkig 17 characters preciding the decimal point
            if ((value.IndexOf(".") != -1) & (Decimal.TryParse(value, out _)))  
                if (value.Split(".")[0].Length > 17)     
                    msg += name + " should be less than 18 characters." + LineEnd;
            // checking 18 charactes (including decimal)
            if ((value.IndexOf(".") == -1) & (Decimal.TryParse(value, out _)))   
                if (value.Length > 17)
                    msg += name + " should be less than 18 characters." + LineEnd;
            return msg;
        }

         // User input data is validated: Date
        public static string IsDate(string value, string name) // Validation method
        {
            string msg = "";
            if (!DateTime.TryParse(value, out _)) // Check if Date format is correct
            {
                msg += name + " must be a valid date." + LineEnd;
            }
            return msg;
        }

        }
}


