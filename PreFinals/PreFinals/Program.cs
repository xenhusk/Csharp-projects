using System;

namespace PreFinals
{

    public class Interfaces
    {
        public static void Main(string[] args)
        {
            Console.ReadKey();
        }

    }
    public class Transactions : ITransactions
    {
        public void showTransaction() {

        }
        public double getAmount() {
            return 0;
        }
    }
    public interface ITransactions
    {
        public void showTransaction();
        public double getAmount();
    }

    public interface ISquare {
        public int getSquareArea(int side) {
            return side * side;
        }
    }
    public interface IRectangle{
        public int getRectangleArea(int b, int h) {
            return b * h;
        }
    }
    public interface ITriangle {
        public double getTriangleArea(double b, double h) {
            return b * h / 2;
        }
    }
}