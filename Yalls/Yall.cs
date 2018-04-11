using System;
using System.Collections.Generic;

namespace Yalls
{
    [Serializable]
    public class Yall
    {
        public float xpos;
        public float ypos;
        private int velocity;
        public float velocity_x;
        public float velocity_y;
        private float c_velocity_x = 0;
        private float c_velocity_y = 0;
        public int gene_1;
        public int gene_2;
        public int gene_3;
        public int max_age;
        public int age;
        public bool weary;
        private int multpl_r;
        private static Random rnd = new Random((int)DateTime.Now.Ticks);

        public Yall(float x = 0, float y = 0, int velocity = 4, int g1 = 0, int g2 = 0, int g3 = 0, int max_age = 50, int rad = 20)
        {
            
            this.xpos = x;
            this.ypos = y;
            this.gene_1 = g1;
            this.gene_2 = g2;
            this.gene_3 = g3;
            this.velocity = velocity;
            this.velocity_x = rnd.Next(-velocity, velocity+1);
            this.velocity_y = rnd.Next(-velocity, velocity+1);
            this.age = 0;
            this.max_age = max_age;
            this.multpl_r = rad;
            this.weary = false;
        }
        private void choosePath() //ялл выбирает, куда двигаться
        {
            int choice = rnd.Next(1, 7);
            if (choice == 6)
            {
                velocity_x = rnd.Next(-velocity, velocity + 1);
                velocity_y = rnd.Next(-velocity, velocity + 1);
            }
            if (choice == 3)
            {
                velocity_x = rnd.Next(-velocity, velocity + 1);
            }
            if (choice == 1)
            {
                velocity_y = rnd.Next(-velocity, velocity + 1);
            }
            c_velocity_x = velocity_x;
            c_velocity_y = velocity_y;
        }
        public void Move() //ялл двигается, если у него есть энергия
        {
            if (xpos > 753f || xpos < 15f)
                c_velocity_x = -velocity_x;
            else if (ypos > 753f || ypos < 15f)
                c_velocity_y = -velocity_y;
            else
                choosePath();
            xpos += c_velocity_x;
            ypos += c_velocity_y;
        }
        public Yall Multiplication(List<Yall> colony) //функция размножения
        {
            foreach (Yall pal in colony)
            {
                if (Math.Abs(pal.xpos - this.xpos) == multpl_r || Math.Abs(pal.ypos - this.ypos) == multpl_r && pal != this)
                {
                    //блок передачи генов цвета с проверкой, чтобы фактор мутации не сделал его больше 255
                    int ng1 = 0, ng2 = 0, ng3 = 0;
                    int t1 = rnd.Next(-10, 11);
                    int t2 = rnd.Next(-10, 11);
                    int t3 = rnd.Next(-10, 11);
                    
                    if ((t1 + (pal.gene_1 + this.gene_1) / 2) > 255)
                        ng1 = 255;
                    else if ((t1 + (pal.gene_1 + this.gene_1) / 2) < 0)
                        ng1 = 0;
                    else
                        ng1 = (t1 + (pal.gene_1 + this.gene_1) / 2);
                    if ((t2 + (pal.gene_2 + this.gene_2) / 2) > 255)
                        ng2 = 255;
                    else if ((t2 + (pal.gene_2 + this.gene_2) / 2) < 0)
                        ng2 = 0;
                    else
                        ng2 = (t2 + (pal.gene_2 + this.gene_2) / 2);
                    if ((t3 + (pal.gene_3 + this.gene_3) / 2) > 255)
                        ng3 = 255;
                    else if ((t3 + (pal.gene_3 + this.gene_3) / 2) < 0)
                        ng3 = 0;
                    else
                        ng3 = (t3 + (pal.gene_3 + this.gene_3) / 2);
                    //расположение потомка с проверкой не выхода за границы
                    float mx = 0, my = 0;
                    int v1 = rnd.Next(-15, 16);
                    int v2 = rnd.Next(-15, 16);
                    if (v1 + this.xpos > 753f || v1 + this.xpos < 15f)
                        mx = this.xpos - v1;
                    else mx = this.xpos + v1;
                    if (v2 + this.ypos > 753f || v2 + this.ypos < 15f)
                        my = this.ypos - v2;
                    else my = this.ypos + v2;

                    return new Yall(mx, my, (this.velocity + pal.velocity) / 2, ng1, ng2, ng3, rnd.Next(-5, 6) + (pal.max_age + this.max_age) / 2, multpl_r);
                }
                else 
                    return null;
            }
            return null;
        }
        public void Aging(List<Yall> colony) //старение и умирание
        {
            if (age > max_age)
            {
                weary = true;
            }
            foreach (Yall pal in colony)
            {
                if (Math.Abs(pal.xpos - this.xpos) == 0 && Math.Abs(pal.ypos - this.ypos) == 0 && pal != this)
                {
                    pal.weary = true;
                    this.weary = true;
                }
            }
        }
    }
}