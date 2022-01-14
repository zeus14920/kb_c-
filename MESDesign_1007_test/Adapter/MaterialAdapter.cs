using MESDesign_code.DBO;
using MESDesign_code.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESDesign_code.Adapter
{
    class MaterialAdapter
    {
        // S2933 오류
        // 읽기, 쓰기 둘 다 해야함으로 예외처리
#pragma warning disable S2933 // Fields that are only assigned in the constructor should be "readonly"
        List<Material> matList = new List<Material>();
        // S2933 오류
        // 읽기, 쓰기 둘 다 해야함으로 예외처리
        List<MaterialAddSub> matAddSubList = new List<MaterialAddSub>();
#pragma warning restore S2933 // Fields that are only assigned in the constructor should be "readonly"

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
