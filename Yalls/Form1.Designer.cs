namespace Yalls
{
    partial class Yalls
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
            this.components = new System.ComponentModel.Container();
            this.world_cont = new System.Windows.Forms.PictureBox();
            this.start_btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.show_coordinates = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.start_size = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.vel_set = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.mult_rad = new System.Windows.Forms.NumericUpDown();
            this.start_over_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.load_btn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.st_size = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.world_cont)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.start_size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vel_set)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mult_rad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.st_size)).BeginInit();
            this.SuspendLayout();
            // 
            // world_cont
            // 
            this.world_cont.BackColor = System.Drawing.Color.White;
            this.world_cont.Location = new System.Drawing.Point(227, 7);
            this.world_cont.Name = "world_cont";
            this.world_cont.Size = new System.Drawing.Size(768, 768);
            this.world_cont.TabIndex = 0;
            this.world_cont.TabStop = false;
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(12, 12);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(98, 23);
            this.start_btn.TabIndex = 1;
            this.start_btn.Text = "Start simulation";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // show_coordinates
            // 
            this.show_coordinates.AutoSize = true;
            this.show_coordinates.Location = new System.Drawing.Point(116, 16);
            this.show_coordinates.Name = "show_coordinates";
            this.show_coordinates.Size = new System.Drawing.Size(111, 17);
            this.show_coordinates.TabIndex = 2;
            this.show_coordinates.Text = "Show coordinates";
            this.show_coordinates.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Colony size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Average lifespan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Generation";
            // 
            // start_size
            // 
            this.start_size.Location = new System.Drawing.Point(113, 46);
            this.start_size.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.start_size.Name = "start_size";
            this.start_size.Size = new System.Drawing.Size(66, 20);
            this.start_size.TabIndex = 6;
            this.start_size.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Initial colony size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Velocity abs";
            // 
            // vel_set
            // 
            this.vel_set.Location = new System.Drawing.Point(113, 70);
            this.vel_set.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.vel_set.Name = "vel_set";
            this.vel_set.Size = new System.Drawing.Size(66, 20);
            this.vel_set.TabIndex = 8;
            this.vel_set.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Multiplication radius";
            // 
            // mult_rad
            // 
            this.mult_rad.Location = new System.Drawing.Point(113, 96);
            this.mult_rad.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.mult_rad.Name = "mult_rad";
            this.mult_rad.Size = new System.Drawing.Size(66, 20);
            this.mult_rad.TabIndex = 10;
            this.mult_rad.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // start_over_btn
            // 
            this.start_over_btn.Location = new System.Drawing.Point(12, 220);
            this.start_over_btn.Name = "start_over_btn";
            this.start_over_btn.Size = new System.Drawing.Size(75, 23);
            this.start_over_btn.TabIndex = 12;
            this.start_over_btn.Text = "Clear";
            this.start_over_btn.UseVisualStyleBackColor = true;
            this.start_over_btn.Click += new System.EventHandler(this.start_over_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(12, 249);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 13;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // load_btn
            // 
            this.load_btn.Location = new System.Drawing.Point(12, 278);
            this.load_btn.Name = "load_btn";
            this.load_btn.Size = new System.Drawing.Size(75, 23);
            this.load_btn.TabIndex = 14;
            this.load_btn.Text = "Load";
            this.load_btn.UseVisualStyleBackColor = true;
            this.load_btn.Click += new System.EventHandler(this.load_btn_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "yalls_colony.dat";
            this.saveFileDialog1.Filter = "Файлы данных (*.dat)|*.dat|Все файлы (*.*)|*.*";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "yalls_colony.dat";
            this.openFileDialog1.Filter = "Файлы данных (*.dat)|*.dat|Все файлы (*.*)|*.*";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Yall size";
            // 
            // st_size
            // 
            this.st_size.Location = new System.Drawing.Point(113, 122);
            this.st_size.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.st_size.Name = "st_size";
            this.st_size.Size = new System.Drawing.Size(66, 20);
            this.st_size.TabIndex = 15;
            this.st_size.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Yalls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 787);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.st_size);
            this.Controls.Add(this.load_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.start_over_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mult_rad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.vel_set);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.start_size);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.show_coordinates);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.world_cont);
            this.Name = "Yalls";
            this.Text = "Yalls";
            ((System.ComponentModel.ISupportInitialize)(this.world_cont)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.start_size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vel_set)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mult_rad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.st_size)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox world_cont;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox show_coordinates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown start_size;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown vel_set;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown mult_rad;
        private System.Windows.Forms.Button start_over_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button load_btn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown st_size;
    }
}

