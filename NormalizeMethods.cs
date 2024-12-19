using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class NormalizeMethods
    {
        public int DimensionOfGrid { get; set; }
        public NormalizeMethods(int dimension) 
        {
            DimensionOfGrid = dimension; //использовать эту размерность при расчетах
        }
        public Point NormalizeCoordinates_ToBufferFormat(Point PB_Coord)
        {
            Point NormalizedCoordinates = new Point();
            //тут пересчет координат из координат пикчербокса в координаты буфферного массива

            return NormalizedCoordinates;
        }

        public Point GetNormalizedCoord_BySymbol(Point PB_Coord, string UserSymbol)
        {
            Point NormalizedCoordinates = new Point();
            if (UserSymbol == "X")
                NormalizedCoordinates = NormalizedCoordinates_GetCenter(PB_Coord);
            else if (UserSymbol == "O")
                NormalizedCoordinates = NormalizedCoordinates_GetLeftTop(PB_Coord);
            return NormalizedCoordinates;
        }

        private Point NormalizedCoordinates_GetCenter(Point PB_Coord)
        { 
            Point CenterOfClick = new Point();
            //тут нахождение центра клетки после клика (для крестика)
            return CenterOfClick; 
        }

        private Point NormalizedCoordinates_GetLeftTop(Point PB_Coord)
        {
            Point LeftTop = new Point();
            //тут нахождение левого верхнего угла клетки (для нолика)
            return LeftTop;
        }

    }
}
