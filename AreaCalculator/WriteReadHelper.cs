using System;

namespace AreaCalculator {

    internal class WriteReadHelper {

        ///<summary>Quick hand to output line to console</summary>
        ///<param name="writeline">text to output</param>
        public void writeLine(String writeline) {
            Console.WriteLine(writeline);
        }

        ///<summary>Checks if a string has an illeagal character</summary>
        ///<param name="input">string input</param>
        ///<returns>Boolean</returns>
        public Boolean hasIllegalChar(String input) {
            //Converts the String into a Char array and sets it to an veriable
            var charInput = input.ToCharArray();

            Boolean hasNumber = false;

            //Lopps around the charInput array.
            for (int c = 0; c < charInput.Length; ++c) {
                //Check's if the Char is numerical or has punctuation
                if ((Char.IsDigit(charInput[c])) || (Char.IsPunctuation(charInput[c]))) {
                    hasNumber = true;
                    break;
                }
                else {
                    hasNumber = false;
                }
            }

            return hasNumber;
        }

        /// <summary>
        /// Gets string from user input and checks if it has no illegal characters and then returns it.
        /// </summary>
        /// <returns></returns>
        public String getString() {
            String readLine = Console.ReadLine();
            String output = "";
            int intOut;
            Boolean isString = readLine.Equals("");
            Boolean hasNumricalChars = hasIllegalChar(readLine);

            while (hasNumricalChars && !isString) {
                Console.WriteLine("Enter some text");
                readLine = Console.ReadLine();
                hasNumricalChars = hasIllegalChar(readLine);
            }

            if (!hasNumricalChars && !isString) {
                output = readLine;
            }

            return output;
        }

        /// <summary>
        /// Returns double from user input
        /// </summary>
        /// <returns>Double</returns>
        public Double getDouble() {
            String readLine = Console.ReadLine();
            Boolean isDouble = Double.TryParse(readLine, out Double testOut);
            Double output = 0.0;

            //It checks if user input is a double if not it will loop around and ask the user to input a vaild number
            while (!isDouble) {
                Console.WriteLine("Write a vaild number");
                readLine = Console.ReadLine();
                isDouble = Double.TryParse(readLine, out Double testOut2);
            }

            //If true it converts the String into a double and sets the veriable "output"
            if (isDouble) {
                output = Double.Parse(readLine);
            }

            return output;
        }

        public int getInt() {
            String readLine = Console.ReadLine();
            Boolean isInt = int.TryParse(readLine, out int testOut);
            int output = 0;

            //It checks if user input is a int if not it will loop around and ask the user to input a vaild number
            while (!isInt) {
                Console.WriteLine("Write a vaild number");
                readLine = Console.ReadLine();
                isInt = int.TryParse(readLine, out int testOut2);
            }

            //If true it converts the String into a double and sets the veriable "output"
            if (isInt) {
                output = int.Parse(readLine);
            }

            return output;
        }

        /// <summary>
        /// Outputs text to console and return Double
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public Double writeAndGetDouble(String input) {
            if (!input.Equals("")) {    
                writeLine(input);
            }

            return getDouble();
        }

        public int writeAndGetInt(String input) {
            if (!input.Equals("")) {
                writeLine(input);
            }

            return getInt();
        }

        /// <summary>
        /// Outputs text to console and returns String
        /// </summary>
        /// <param name="input"></param>
        /// <returns>String</returns>
        public String writeAndGetString(String input) {
            //Checks if imputed string is not empty and then outputs line
            if (!input.Equals("")) {
                writeLine(input);
            }

            return getString();
        }


        public void askToGoBack() {
            writeLine("");
            writeLine("");
            writeLine("-----------------------------------");
            writeLine("Start over or go back to main menu?");
            writeLine("-----------------------------------");
            writeLine("-----------------------------------");
            writeLine("Select number between 0 - 1");
            writeLine("-----------------------------------");
            writeLine("");
            writeLine("  (0) -- Go back to Main Menu");
            writeLine("  (1) -- Start Area Calculator over ");
            int choice = getInt();
            areaMain area = new areaMain();
            if (choice == 0) {
                area.Start();
            } else if (choice == 1) {
                return;
            } else {
                writeLine("Enter number between 0 & 1");
                getInt();
            }



        }
    }
}