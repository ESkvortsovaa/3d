using Logic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3d
{
#pragma warning disable CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена
    public class MyPaint
#pragma warning restore CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена
    {
        // угол
        /// <summary>
        /// 
        /// </summary>
        public double coal_OXY { get; set; }

        // угол
        /// <summary>
        /// 
        /// </summary>
        public double coal_res_OXY { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Point Point_0 { get; set; }
                
        /// <summary>
        ///фигура 
        /// </summary>
        public Figure figure_3D { get; set; }

        // pen для проекции figure_3D
        Pen pen_figure_3D = new Pen(Color.Black);

        /// <summary>
        /// для временного хранения при поворотах
        /// </summary>
        public int tmp_XX {get;set;}
        /// <summary>
        /// 
        /// </summary>
        public int tmp_YY { get; set; }

#pragma warning disable CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена
        public MyPaint(int width, int height)
#pragma warning restore CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена
        {
            Point_0 = new Point(width / 2, height / 2);

            // установим углы
            coal_OXY = 1.0;
            coal_res_OXY = 1.0;
        }

        // проекция 2D на 2D
        private Point Convert_3D_in_2D_Point(Point3D val)
        {
            // проицируем
            double res_x = -val._z * System.Math.Sin(coal_OXY) + val._x * System.Math.Cos(coal_OXY) + Point_0.X;
            double res_y = -(val._z * System.Math.Cos(coal_OXY) + val._x * System.Math.Sin(coal_OXY)) * System.Math.Sin(coal_res_OXY) + val._y * System.Math.Cos(coal_res_OXY) + Point_0.Y;

            return new Point((int)(res_x), (int)(res_y));
        }


        // рисуем
#pragma warning disable CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена
        public Bitmap Draw(Figure figure, int width, int height)
#pragma warning restore CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена
        {
            figure_3D = figure;
            Bitmap bmp = new Bitmap(width, height);
            if (figure_3D != null)
            {
                // создадим bitmap и Graphics
                Graphics grf = Graphics.FromImage(bmp);

                // пербираем
                for (int i = 0; i < figure.figure_3D.Count - 1; i++)
                {
                    grf.DrawLine(pen_figure_3D, Convert_3D_in_2D_Point(figure.figure_3D[i]), Convert_3D_in_2D_Point(figure.figure_3D[i + 1]));
                }
            }
            return bmp;            
        }
    }
}
