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
        List<MaterialAddSub> matAddSubList = new List<MaterialAddSub>();

        public void addToList(Material mat)
        {
            matList.Add(mat);
            addToDB(mat);
        }

        public void addToDB(Material mat)
        {
            OraMgr.Instance.insertMatDB(mat);
        }

        public void addToMatList(Material mat, MaterialAddSub matAddSub)
        {
            matList.Add(mat);
            matAddSubList.Add(matAddSub);
            addToMatDB(mat, matAddSub);
        }

        public void addToMatDB(Material mat, MaterialAddSub matAddSub)
        {
            OraMgr.Instance.updateAddQuantityDB(mat,matAddSub);
        }

        public void subToMatList(Material mat, MaterialAddSub matAddSub)
        {
            matList.Add(mat);
            matAddSubList.Add(matAddSub);
            subToMatDB(mat, matAddSub);
        }

        public void subToMatDB(Material mat, MaterialAddSub matAddSub)
        {
            OraMgr.Instance.updateSubQuantityDB(mat, matAddSub);
        }

        public List<Material> getMaterialPlusDB()
        {
            List<Material> list = OraMgr.Instance.getMaterialPlusVo();
            return list;
        }

        public void getMaterialDB(out List<Material> list, out List<MaterialAddSub> addSubList)
        {
            OraMgr.Instance.getMaterialVo(out list, out addSubList);            
        }
    }
}
