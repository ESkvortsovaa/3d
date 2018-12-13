using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Logic
{
    public  class Cube:Figure
    {
        
        
        public Cube(int size)
        {
            figure_3D = new List<Point3D>();

            figure_3D.Add(new Point3D(0, 0, 0));
            figure_3D.Add(new Point3D(size, 0, 0));
            figure_3D.Add(new Point3D(size, 0, size));
            figure_3D.Add(new Point3D(0, 0, size));
            figure_3D.Add(new Point3D(0, size, size));
            figure_3D.Add(new Point3D(0, size, 0));
            figure_3D.Add(new Point3D(0, 0, 0));
            figure_3D.Add(new Point3D(0, size, 0));
            figure_3D.Add(new Point3D(size, size, 0));
            figure_3D.Add(new Point3D(size, size, size));
            figure_3D.Add(new Point3D(size, 0, size));
            figure_3D.Add(new Point3D(size, 0, 0));
            figure_3D.Add(new Point3D(size, size, 0));
            figure_3D.Add(new Point3D(0, size, 0));
            figure_3D.Add(new Point3D(0, size, size));
            figure_3D.Add(new Point3D(size, size, size));
            figure_3D.Add(new Point3D(size, 0, size));
            figure_3D.Add(new Point3D(0, 0, size));
            figure_3D.Add(new Point3D(0, 0, 0));


        }
    }
}
