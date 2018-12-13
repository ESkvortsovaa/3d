namespace _3d
{
    partial class Form_main
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox_main = new System.Windows.Forms.PictureBox();
            this.button_prism = new System.Windows.Forms.Button();
            this.trackBar_OX = new System.Windows.Forms.TrackBar();
            this.trackBar_res_OXY = new System.Windows.Forms.TrackBar();
            this.button_cub = new System.Windows.Forms.Button();
            this.button_octaidre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_OX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_res_OXY)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_main
            // 
            this.pictureBox_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_main.BackColor = System.Drawing.Color.Silver;
            this.pictureBox_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_main.Location = new System.Drawing.Point(18, 18);
            this.pictureBox_main.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox_main.Name = "pictureBox_main";
            this.pictureBox_main.Size = new System.Drawing.Size(681, 374);
            this.pictureBox_main.TabIndex = 0;
            this.pictureBox_main.TabStop = false;
            this.pictureBox_main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_main_MouseDown);
            this.pictureBox_main.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_main_MouseMove);
            // 
            // button_prism
            // 
            this.button_prism.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_prism.Location = new System.Drawing.Point(785, 18);
            this.button_prism.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_prism.Name = "button_prism";
            this.button_prism.Size = new System.Drawing.Size(144, 45);
            this.button_prism.TabIndex = 1;
            this.button_prism.Text = "тетраэдр";
            this.button_prism.UseVisualStyleBackColor = true;
            this.button_prism.Click += new System.EventHandler(this.button_prism_Click);
            // 
            // trackBar_OX
            // 
            this.trackBar_OX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_OX.Location = new System.Drawing.Point(18, 403);
            this.trackBar_OX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar_OX.Maximum = 628;
            this.trackBar_OX.Name = "trackBar_OX";
            this.trackBar_OX.Size = new System.Drawing.Size(681, 69);
            this.trackBar_OX.TabIndex = 2;
            this.trackBar_OX.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar_OX.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar_res_OXY
            // 
            this.trackBar_res_OXY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_res_OXY.Location = new System.Drawing.Point(709, 18);
            this.trackBar_res_OXY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar_res_OXY.Maximum = 628;
            this.trackBar_res_OXY.Name = "trackBar_res_OXY";
            this.trackBar_res_OXY.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_res_OXY.Size = new System.Drawing.Size(69, 375);
            this.trackBar_res_OXY.TabIndex = 3;
            this.trackBar_res_OXY.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar_res_OXY.Scroll += new System.EventHandler(this.trackBar_res_OXY_Scroll);
            // 
            // button_cub
            // 
            this.button_cub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cub.Location = new System.Drawing.Point(785, 72);
            this.button_cub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_cub.Name = "button_cub";
            this.button_cub.Size = new System.Drawing.Size(144, 45);
            this.button_cub.TabIndex = 4;
            this.button_cub.Text = "куб";
            this.button_cub.UseVisualStyleBackColor = true;
            this.button_cub.Click += new System.EventHandler(this.button_cub_Click);
            // 
            // button_octaidre
            // 
            this.button_octaidre.Location = new System.Drawing.Point(785, 125);
            this.button_octaidre.Name = "button_octaidre";
            this.button_octaidre.Size = new System.Drawing.Size(144, 46);
            this.button_octaidre.TabIndex = 5;
            this.button_octaidre.Text = "октаэдр";
            this.button_octaidre.UseVisualStyleBackColor = true;
            this.button_octaidre.Click += new System.EventHandler(this.button_octaidre_Click);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 491);
            this.Controls.Add(this.button_octaidre);
            this.Controls.Add(this.button_cub);
            this.Controls.Add(this.trackBar_res_OXY);
            this.Controls.Add(this.trackBar_OX);
            this.Controls.Add(this.button_prism);
            this.Controls.Add(this.pictureBox_main);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3D";
            this.Resize += new System.EventHandler(this.Form_main_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_OX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_res_OXY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_main;
        private System.Windows.Forms.Button button_prism;
        private System.Windows.Forms.TrackBar trackBar_OX;
        private System.Windows.Forms.TrackBar trackBar_res_OXY;
        private System.Windows.Forms.Button button_cub;
        private System.Windows.Forms.Button button_octaidre;
    }
}

