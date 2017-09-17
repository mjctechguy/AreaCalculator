using System;

namespace AreaCalculator {

    internal class areaMain {
        private static WriteReadHelper writer = new WriteReadHelper();

        public areaMain() {
            Console.Title = "Area Calucalotr";
        }

        public void Start() {
            writer.writeLine("---------------------------");
            writer.writeLine("Welcome to Area Calculator");
            writer.writeLine("---------------------------");
            GetAreaType();
        }

        private void GetAreaType() {
            Double areaType;
            String[] shapeTypes = new String[] { "square", "rectangle", "circle", "triangle", "cone" };

            writer.writeLine("");
            for (int i = 0; i < shapeTypes.Length; ++i) {
                Console.WriteLine("  ({0}) -- {1}", i, shapeTypes[i]);
            }
            writer.writeLine("");

            writer.writeLine("---------------------------");
            writer.writeLine("Select number between 0 - 4");
            writer.writeLine("---------------------------");
            areaType = writer.getDouble();

            switch (areaType) {
                case 0:
                    areaOfSquare a = new areaOfSquare();
                    a.start();
                    break;

                case 1:
                    Console.WriteLine(shapeTypes[1]);
                    break;

                case 2:
                    Console.WriteLine(shapeTypes[2]);
                    break;

                case 3:
                    Console.WriteLine(shapeTypes[3]);
                    break;

                case 4:
                    Console.WriteLine(shapeTypes[4]);
                    break;

                default:
                    Console.WriteLine("Please enter a vaid string");
                    break;
            }
        }
    }
    }