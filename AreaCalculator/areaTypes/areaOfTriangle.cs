using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.areaTypes {
    class AreaOfTriangle : IArea {
        public double shapeWidth { get ; set; }
        public double shapeHeight { get; set; }
        public double shapeRadius { get; set; }
        public double shapeBase { get; set; }

        private WriteReadHelper writer = new WriteReadHelper();

        public AreaOfTriangle() {
            start();
        }

        public void start() {
            writer.writeLine("---------------------------------");
            writer.writeLine("Welcome to the Area of a Triangle Calucaltor");
            writer.writeLine("---------------------------------");
            shapeBase = writer.writeAndGetDouble("Please enter the base");
            shapeHeight = writer.writeAndGetDouble("Please neter the height");

            calcuate(0,shapeHeight,0,shapeBase);
        }

        public void calcuate(double w, double h, double r, double b) {
            Double output = (b/2) * h;
            outputValue(output);
        }

        public void outputValue(double sum) {
            writer.writeLine("The area of the triangle is: " + " " + sum);
            writer.askToGoBack();
        }
    }
}
