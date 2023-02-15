using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr12_3
{
    public class robot
    {
        public int kollife;

        public int getlife()//метод для чтения из закрытого поля
        {
            return kollife;
        }

        public void min(int a)//метод, определяющий изменение количества жизней робота
        {
            kollife = a;
            kollife = (int)kollife / 2;
        }
        public void kol(int a, int k)
        {
            if (k == a / 2)
            {
                kollife = kollife + 30;
            }
            else if (k == a * 0.7)
            {
                kollife += 20;
            }
            else if (k>=a/2 && k<a*0.7)
            {
               kollife += 40;
            }
            else if (k < a/2 && k>0)
            {
              kollife += 50;
            }
            else if (k == 0)
            {
              kollife += 100;
            }
        }
    }
}

