using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic

{


    /// Класс описывающий точку в 3D пространстве
   
    public class Point3D
    {
       
        /// координата X
       
        public int _x { set; get; }
       
        /// координата Y
    
        public int _y { set; get; }
    
        /// координата Z
     
        public int _z { set; get; }
     
        /// конструктор 1
        
        public Point3D ()
        {
             _x = 0;
             _y = 0;
             _z = 0;
        }

        /// конструктор 2
      
        public Point3D(int x, int y, int z)
        {
            _x = x;
            _y = y;
            _z = z;
        }
    }
}
