using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESDesign_code.Model
{
    class MaterialAddSub
    {
        string receiving;
        string shipping;
        string invertory;
        string time;

        public MaterialAddSub(string receiving, string shipping, string invertory, string time)
        {
            this.receiving = receiving;
            this.shipping = shipping;
            this.invertory = invertory;
            this.time = time;
        }

        public MaterialAddSub(string receiving, string shipping, string invertory)
        {
            this.receiving = receiving;
            this.shipping = shipping;
            this.invertory = invertory;
        }

        public string Receiving { get => receiving; set => receiving = value; }
        public string Shipping { get => shipping; set => shipping = value; }
        public string Invertory { get => invertory; set => invertory = value; }
        public string Time { get => time; set => time = value; }
    }
}
