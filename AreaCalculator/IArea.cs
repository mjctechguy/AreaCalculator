using System;

namespace AreaCalculator {

    internal interface IArea {
        Double shapeWidth { get; set; }
        Double shapeHeight { get; set; }
        Double shapeRadius { get; set; }
        Double shapeBase { get; set; }

        void calcuate(Double w, Double h, Double r, Double b);

        void outputValue(Double sum);
    }
}