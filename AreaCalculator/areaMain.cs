using System;
using AreaCalculator.areaTypes;

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
                    AreaOfSquare aS = new AreaOfSquare();
                    aS.start();
                    break;

                case 1:
                    Console.WriteLine(shapeTypes[1]);
                    break;

                case 2:
                    AreaOfCircle aCI = new AreaOfCircle();
                    aCI.start();
                    break;

                case 3:
                    AreaOfTriangle aT = new AreaOfTriangle();
                    aT.start();
                    break;

                case 4:
                    AreaOfCone aC = new AreaOfCone();
                    aC.start();
                    break;

                default:
                    Console.WriteLine("Please enter a vaid string");
                    break;
            }
        }
    }
    }