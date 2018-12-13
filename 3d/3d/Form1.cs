using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace _3d
{
 
    /// класс основной формы
    

    public partial class Form_main : Form
    {
        MyPaint MyPaint;
       
        /// конструктор формы
                
        public Form_main()
        {
            InitializeComponent();

            MyPaint = new MyPaint(pictureBox_main.Width, pictureBox_main.Height);

            //
            trackBar_OX.Value = 100;
            trackBar_res_OXY.Value = 100;
        }               

       
        // выводим 
        private void Reload(Bitmap bmp)
        {
            pictureBox_main.Image = bmp;
            pictureBox_main.Refresh();
        }
        
        // куб
        private void button_cub_Click(object sender, EventArgs e)
        {
            Cube cube = new Cube(100);
            Reload(MyPaint.Draw(cube, pictureBox_main.Width, pictureBox_main.Height));
        }

        // для DOWNmous
        private void pictureBox_main_MouseDown(object sender, MouseEventArgs e)
        {
            // зададим точку отсчета
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MyPaint.Point_0 = new Point(e.X, e.Y);
            }
        }
     
        // клик по кнопки куб
        private void button_prism_Click(object sender, EventArgs e)
        {
            Tetraidre tetraidre = new Tetraidre(100);
            Reload(MyPaint.Draw(tetraidre, pictureBox_main.Width, pictureBox_main.Height));
        }

        // перемещение мыши
        private void pictureBox_main_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {               
                // вправо
                if (e.X > MyPaint.tmp_XX)
                {
                    if (trackBar_OX.Value <= trackBar_OX.Maximum && trackBar_OX.Value > 0)
                    {                      
                        trackBar_OX.Value -= 1;
                        trackBar1_Scroll(this, EventArgs.Empty);                                                                       
                    }
                    else
                    {                        
                        if (trackBar_OX.Value == 0)
                            trackBar_OX.Value = trackBar_OX.Maximum;
                    }
                }

                // влево
                if (e.X < MyPaint.tmp_XX)
                {
                    if (trackBar_OX.Value < trackBar_OX.Maximum && trackBar_OX.Value >= 0)
                    { 
                        trackBar_OX.Value += 1;
                        trackBar1_Scroll(this, EventArgs.Empty);

                        // переход через MAX
                        if (trackBar_OX.Value >= trackBar_OX.Maximum)
                            trackBar_OX.Value = 0;     
                    }
                }
                // вниз
                if (e.Y > MyPaint.tmp_YY)
                {
                    if (trackBar_res_OXY.Value < trackBar_res_OXY.Maximum && trackBar_res_OXY.Value >= 0)
                    {
                        trackBar_res_OXY.Value += 1;
                        trackBar_res_OXY_Scroll(this, EventArgs.Empty);
                    }
                    else
                    {
                        // переход через MAX
                         if (trackBar_res_OXY.Value >= trackBar_OX.Maximum)
                             trackBar_res_OXY.Value = 0;
                    }
                }

                // вверх
                if (e.Y < MyPaint.tmp_YY)
                {
                    if (trackBar_res_OXY.Value <= trackBar_res_OXY.Maximum && trackBar_res_OXY.Value > 0)
                    { 
                        trackBar_res_OXY.Value -= 1;
                        trackBar_res_OXY_Scroll(this, EventArgs.Empty);
                    }
                    else
                    {
                        // переход через 0
                        if (trackBar_res_OXY.Value <= 0)
                            trackBar_res_OXY.Value = trackBar_res_OXY.Maximum;  
                    }
                }
                // временно для хранения
                MyPaint.tmp_XX = e.X;
                MyPaint.tmp_YY = e.Y;

                return; 
            }

            // пермещаем точку отсчета 0
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MyPaint.Point_0 = new Point(e.X, e.Y);
                Reload(MyPaint.Draw(MyPaint.figure_3D, pictureBox_main.Width, pictureBox_main.Height));
            }
        }

        // поворот
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            MyPaint.coal_OXY = (double)(trackBar_OX.Value) / 100;
            Reload( MyPaint.Draw(MyPaint.figure_3D, pictureBox_main.Width, pictureBox_main.Height));
        }

        // поворот
        private void trackBar_res_OXY_Scroll(object sender, EventArgs e)
        {
            MyPaint.coal_res_OXY = (double)(trackBar_res_OXY.Value) / 100;
            Reload(MyPaint.Draw(MyPaint.figure_3D, pictureBox_main.Width, pictureBox_main.Height));
        }

        // изменение размеров формы
        private void Form_main_Resize(object sender, EventArgs e)
        {
            
        }

        private void button_octaidre_Click(object sender, EventArgs e)
        {
            Octaidre octaidre = new Octaidre(100);
            Reload(MyPaint.Draw(octaidre, pictureBox_main.Width, pictureBox_main.Height));
        }
    }
}
