using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Matrix
    {
        private int x;
        private int y;
        private int[,] mtrx;

        public Matrix(int a, int b)
        {
            x = a;
            y = b;
            mtrx = new int[x, y];
        }

        public int getX()
        {
            return x;
        }

        public int getY()
        {
            return y;
        }

        public int[,] getMtrx()
        {
            return mtrx;
        }

        public void setMtrxEl(int x, int y, int el)
        {
            if(this.x<=x&&this.y<=y)
            mtrx[x,y] = el;
        }
    }
}
