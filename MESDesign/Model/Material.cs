using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESDesign.Model
{
    class Material
    {
        string code;
        string name;
        string price;
        string wearing;
        string invertory;
        string time;

        public string Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public string Price { get => price; set => price = value; }
        public string Wearing { get => wearing; set => wearing = value; }
        public string Invertory { get => invertory; set => invertory = value; }
        public string Time { get => time; set => time = value; }

        public Material(string code, string name, string price, string wearing, string invertory)
        {
            this.code = code;
            this.name = name;
            this.price = price;
            this.wearing = wearing;
            this.invertory = invertory;
        }

        public Material(string code, string wearing, string invertory)
        {
            this.code = code;
            this.wearing = wearing;
            this.invertory = invertory;
        }

        public Material(string code, string name, string price, string wearing, string invertory, string time) : this(code, name, price, wearing, invertory)
        {
            this.time = time;
        }
    }
}
