using System;

namespace AreaCalculator.areaTypes {

    class AreaOfCircle : IArea {
        public Double shapeWidth { get; set; }
        public Double shapeHeight { get; set; }
        public Double shapeRadius { get; set; }
        public Double shapeBase { get; set; }

        private WriteReadHelper writer = new WriteReadHelper();

        public AreaOfCircle() {
            start();
        }

        public void start() {
            writer.writeLine("---------------------------------");
            writer.writeLine("Welcome to the Area of a Circle Calucaltor");
            writer.writeLine("---------------------------------");
            shapeRadius = writer.writeAndGetDouble("Please enter the radius");

            calcuate(0, 0, shapeRadius, 0);
        }

        public void calcuate(Double w, Double h, Double r, Double b) {
            Double  radiusSquared = Math.Pow(r, 2);
            Double output = Math.PI * radiusSquared;

            outputValue(Math.Round(output,2));
        }

        public void outputValue(Double sum) {
            writer.writeLine("The area of the circle is: " + " " + sum);
            writer.askToGoBack();
        }
    }
}