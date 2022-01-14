using MESDesign.DBO;
using MESDesign.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESDesign.Adapter
{
    class MaterialAdapter
    {
        List<Material> matList = new List<Material>();

        public void addToList(Material mat)
        {
            matList.Add(mat);
            addToDB(mat);
        }

        public void addToDB(Material mat)
        {
            OraMgr.Instance.insertMatDB(mat);
        }

        public void addToMatList(Material mat)
        {
            matList.Add(mat);
            addToMatDB(mat);
        }

        public void addToMatDB(Material mat)
        {
            OraMgr.Instance.updateQuantityDB(mat);
        }

        public List<Material> getMaterialPlusDB()
        {
            List<Material> list = OraMgr.Instance.getMaterialPlusVo();
            return list;
        }

        public List<Material> getMaterialDB()
        {
            List<Material> list = OraMgr.Instance.getMaterialVo();
            return list;
        }
    }
}
