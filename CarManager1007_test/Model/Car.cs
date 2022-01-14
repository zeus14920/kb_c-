using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager0902.Model
{
    class Car
    {
        string name;
        string color;
        int price;
        string insuDate;
        string manager;

        public Car(string name, string color, int price, string insuDate, string manager)
        {
            this.name = name;
            this.color = color;
            this.price = price;
            this.insuDate = insuDate;
            this.manager = manager;
        }

        // S2292 오류
        // 비쥬얼 스튜디오에서 만들어준 코드 예외 처리
        public string Name { get => name; set => name = value; }
        public string Color { get => color; set => color = value; }
        public int Price { get => price; set => price = value; }
        public string InsuDate { get => insuDate; set => insuDate = value; }
        public string Manager { get => manager; set => manager = value; }
    }
}
