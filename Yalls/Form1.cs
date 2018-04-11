using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Yalls
{
    public partial class Yalls : Form
    {

        Bitmap world = new Bitmap(768,768);
        Graphics grap;
        SolidBrush main_brush = new SolidBrush(Color.Black);
        List<Yall> colony = new List<Yall>();
        List<Yall> temp = new List<Yall>();
        Random rndd = new Random((int)DateTime.Now.Ticks);
        int generation = 0;
        bool go = false;
        bool first = true;
        Dictionary<int, object> datakeeper = new Dictionary<int,object>();
        BinaryFormatter binF = new BinaryFormatter();
        public Yalls()
        {
            InitializeComponent();
            world_cont.Image = world;
            grap = Graphics.FromImage(world);
        }

        private void drawWorld()
        {
            foreach (Yall yall in colony)
            {
                main_brush.Color = Color.FromArgb(yall.gene_1, yall.gene_2, yall.gene_3);
                grap.FillEllipse(main_brush, yall.xpos, yall.ypos, (float)st_size.Value, (float)st_size.Value);
                if (show_coordinates.Checked)
                {
                    main_brush.Color = Color.Black;
                    grap.DrawString(yall.xpos + ";" + yall.ypos + ";" + yall.velocity_x + ";" + yall.velocity_y, DefaultFont, main_brush, new PointF(yall.xpos, yall.ypos + 10)); 
                }
            }
        }
        private void startGraphics()
        {
            for (int i = 0; i < start_size.Value+1; i++ )
            {
                colony.Add(new Yall(rndd.Next(128, 512), rndd.Next(128, 512), (int)vel_set.Value, rndd.Next(255), rndd.Next(255), rndd.Next(255), rndd.Next(25, 76),(int)mult_rad.Value));
            }
            first = false;
            drawWorld();
        }
        private void updateWorld()
        {
            grap.Clear(Color.White);
            for (int i = 0; i < colony.Count; i++ )
            {
                if (colony[i].weary)
                { colony.Remove(colony[i]); }
            }
            foreach (Yall yall in colony)
            {
                yall.Aging(colony);
                yall.Move();
                if (yall.Multiplication(colony) != null)
                { temp.Add(yall.Multiplication(colony)); }
                yall.age++;
            }
            colony.AddRange(temp);
            temp.Clear();
            drawWorld();
            world_cont.Refresh();
        }
        private void start_btn_Click(object sender, EventArgs e)
        {
            if (!go)
            {
                if (first)
                { startGraphics(); }
                timer1.Enabled = true;
                go = true;
                start_btn.Text = "Stop simulation";
            }
            else
            {
                timer1.Enabled = false;
                start_btn.Text = "Start simulation";
                go = false;
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            int m_age = 0;
            int r1;
            for (int i = 0; i < colony.Count; i++)
            {
                m_age += colony[i].max_age;
            }
            updateWorld();
            label1.Text = "Colony size: " + colony.Count;
            if (colony.Count > 0)
            { r1 = colony.Count; }
            else r1 = 1;
            label2.Text = "Average lifespan: " + m_age / r1;
            label3.Text = "Generation: " + generation;
            generation++;
            timer1.Enabled = true;
        }

        private void start_over_btn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            grap.Clear(Color.White);
            world_cont.Invalidate();
            go = false;
            first = true;
            colony.Clear();
            generation = 0;
            start_btn.Text = "Start simulation";
            label1.Text = "Colony size: 0";
            label2.Text = "Average lifespan: 0";
            label3.Text = "Generation: 0";
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            datakeeper.Clear();
            datakeeper.Add(0, generation);
            datakeeper.Add(1, colony);
            MemoryStream data_stream = new MemoryStream();
            binF.Serialize(data_stream, datakeeper);
            string save_data = Convert.ToBase64String(data_stream.ToArray());
            File.WriteAllText(saveFileDialog1.FileName, save_data, Encoding.Default);
            data_stream.Flush();
            data_stream.Close();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            grap = Graphics.FromImage(world);
            datakeeper.Clear();
            string load_data = File.ReadAllText(openFileDialog1.FileName);
            MemoryStream data_stream = new MemoryStream(Convert.FromBase64String(load_data));
            BinaryFormatter binF = new BinaryFormatter();
            datakeeper = (Dictionary<int, object>)binF.Deserialize(data_stream);
            generation = (int)datakeeper[0];
            colony = (List<Yall>)datakeeper[1];
            data_stream.Close();
            first = false;
            int m_age = 0;
            int r1;
            for (int i = 0; i < colony.Count; i++)
            {
                m_age += colony[i].max_age;
            }
            updateWorld();
            label1.Text = "Colony size: " + colony.Count;
            if (colony.Count > 0)
            { r1 = colony.Count; }
            else r1 = 1;
            label2.Text = "Average lifespan: " + m_age / r1;
            label3.Text = "Generation: " + generation;
        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}
