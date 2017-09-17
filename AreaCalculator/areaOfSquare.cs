using System;

namespace AreaCalculator {

    internal class areaOfSquare : IArea {
        public Double shapeWidth { get; set; }
        public Double shapeHeight { get; set; }
        public Double shapeRadius { get; set; }
        public Double shapeBase { get; set; }

        private WriteReadHelper writer = new WriteReadHelper();
        private areaMain area = new areaMain();

        public areaOfSquare() {
            start();
        }

        public void start() {
            writer.writeLine("---------------------------------");
            writer.writeLine("Welcome to the Area of a Square Calucaltor");
            writer.writeLine("---------------------------------");
            shapeWidth = writer.writeAndGetDouble("Please enter the width");
            shapeHeight = writer.writeAndGetDouble("Please neter the height");

            calcuate(shapeWidth, shapeHeight, 0, 0);
        }

        public void calcuate(Double w, Double h, Double r, Double b) {
            Double outut = w * h;
            outputValue(outut);
        }

        public void outputValue(Double sum) {
            writer.writeLine("The area of the square is: " + " " + sum);
            writer.askToGoBack();
        }
    }
}