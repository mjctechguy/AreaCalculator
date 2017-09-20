using System;

namespace AreaCalculator.areaTypes {

    class AreaOfCone : IArea {
        public Double shapeWidth { get; set; }
        public Double shapeHeight { get; set; }
        public Double shapeRadius { get; set; }
        public Double shapeBase { get; set; }

        private WriteReadHelper writer = new WriteReadHelper();

        public AreaOfCone() {
            start();
        }

        public void start() {
            writer.writeLine("---------------------------------");
            writer.writeLine("Welcome to the Area of a cone Calucaltor");
            writer.writeLine("---------------------------------");
            shapeRadius = writer.writeAndGetDouble("Please enter the radius");
            shapeHeight = writer.writeAndGetDouble("Please neter the height");

            calcuate(0, shapeHeight, shapeRadius, 0);
        }

        public void calcuate(Double w, Double h, Double r, Double b) {
            //Times PI by radius
            Double piOut = Math.PI * r;
            //calcuates h^2 using Math.Pow
            Double heightSquared = Math.Pow(shapeHeight,2);
            //calculates r^2 using Math.Pow
            Double radiusSquared = Math.Pow(shapeRadius, 2);
            //Caluates the square route of heightSquared + radiusSquaed
            Double squareRoute = Math.Sqrt(heightSquared + radiusSquared);
            //Adds radius of shape and the calcuauted square route
            Double radiusPlusSquareRoute = shapeRadius + squareRoute;
            //times (pi * r) * (shapeRadius + squareRoute)
            Double output = piOut * radiusPlusSquareRoute;

            outputValue(Math.Round(output,2));
        }

        public void outputValue(Double sum) {
            writer.writeLine("The area of the cone is: " + " " + sum);
            writer.askToGoBack();
        }
    }
}