using System;

namespace structure
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Rectangle rtg = new Rectangle(2,2);              

            Console.WriteLine(rtg.RectangleArea());
         //   Console.WriteLine(rtg.length);
        }
    }

    class Rectangle                                                    //當類別內的程式不再改變，將class改寫成struct
    {
        int area;
        public int length;
        int height;

        public Rectangle(int l = 1, int h = 1)                    //結構的建構式，預設參數的值不會代入變數，而類別就會！
        {
            length = l;
            height = h;
          //  area = a;                                                         //結構的建構式要，全部變數都要代入值，而類別不需要！
        }

        public int RectangleArea()
        {
          //  int area;
            return area = length * height;
        }
    }
}
