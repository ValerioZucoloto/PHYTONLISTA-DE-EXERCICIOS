using System;

class Retangulo {
        private double LadoA;
        private double LadoB;

        public double GetLadoA() {
                return this.LadoA;
        }

        public void SetLadoA (double A) {
                this.LadoA = A;
        }

        public double GetLadoB() {
                return this.LadoB;
        }

        public void SetLadoB(double B) {
                this.LadoB = B;
        }

        public double CalcularArea() {
                return LadoA * LadoB;
        }

        public double Perimetro() {
                return 2 * (LadoA + LadoB);
        }

}