﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub1
{
    internal class Sedan : Car
    {
       
        private int cc;

        public Sedan(string color, string name, int speed, int cc) : base(color, name, speed)
        {
            this.cc = cc;
        }


        public override void SpeedUp(int speed)
        {
            Console.WriteLine("Sedan SpeedUp ...");
            base.speed += speed;
        }
        public override void SpeedDown(int speed)
        {
            Console.WriteLine("Sedan SpeedDown ...");
            base.speed -= speed;
        }


        public override void Show()
        {
            Console.WriteLine("================");
            Console.WriteLine("차량명 : "+name);
            Console.WriteLine("차량색 : "+color);
            Console.WriteLine("차량속도 : "+speed);
            Console.WriteLine("차량배기량 : "+cc);
            Console.WriteLine("-----------------");

        }
        
    }
}
