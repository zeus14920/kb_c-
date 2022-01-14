using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESDesign_code.Model
{
    class Material
    {
        string code;
        string name;
        string price;

        public Material(string code, string name, string price)
        {
            this.code = code;
            this.name = name;
            this.price = price;
        }

        public Material(string code)
        {
            this.code = code;
        }

        public string Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public string Price { get => price; set => price = value; }
    }
}
