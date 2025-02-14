﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch11
{
    public partial class Form3 : Form
    {
        public Graphics graphics;
        Rectangle myRect = new Rectangle();

        Brush blueBrush = new SolidBrush(Color.Blue);
        Pen blackPen = new Pen(Color.Black);

        


        public Form3()
        {
            InitializeComponent();

            graphics = this.CreateGraphics();

            myRect.X = 360;
            myRect.Y = 10;

            myRect.Width = 10;
            myRect.Height = 10;


        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Console.WriteLine("OnPaint!!!");
            graphics.DrawRectangle(blackPen, myRect);
            graphics.FillRectangle(blueBrush, myRect);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            Brush radBrush = new SolidBrush(Color.Red);
            Pen blackPen = new Pen(Color.Black);

            Rectangle rect = new Rectangle(10, 10, 100, 100);

            //도형 그리기
            g.DrawRectangle(blackPen, rect);

            //색 채우기
            g.FillRectangle(radBrush, rect);  
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //선 그리기
            Graphics g = this.CreateGraphics();
            Pen blackPen = new Pen(Color.Black);

            g.DrawLine(blackPen, new Point(10, 120), new Point(200, 120));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            Pen blackPen = new Pen(Color.Black);
            Brush greenBrush = new SolidBrush(Color.Green);

            Rectangle rect = new Rectangle(120, 10, 100, 100);

            g.FillEllipse(greenBrush, rect);
            g.DrawEllipse(blackPen, rect);
        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("myTimer!!!");
            myRect.Y += 10;

            Invalidate();
        }

        

        
    }
}
