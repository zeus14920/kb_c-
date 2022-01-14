using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESDesign.Model
{
    class MaterialAddSub
    {
        string receiving;
        string shipping;
        string time;

        public MaterialAddSub(string receiving, string shipping, string time)
        {
            this.receiving = receiving;
            this.shipping = shipping;
            this.time = time;
        }

        public string Receiving { get => receiving; set => receiving = value; }
        public string Shipping { get => shipping; set => shipping = value; }
        public string Time { get => time; set => time = value; }
    }
}
