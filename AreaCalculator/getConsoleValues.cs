using System;

namespace AreaCalculator {

    internal class getConsoleValues {
        public String question { get; set; }

        public void getValue() {
            if (hasQuestion()) {
                GTV();
            }
            else {
                Console.WriteLine("No inputted string. Press anykey to close");
            }
        }

        public Double GTV() {
            Double output;

            Console.WriteLine(question);

            while (!Double.TryParse(Console.ReadLine(), out output)) {
                Console.WriteLine("Please enter vaild number");
            }
            return output;
        }

        public Boolean hasQuestion() {
            if (question != null) {
                return false;
            }
            return true;
        }
    }
}