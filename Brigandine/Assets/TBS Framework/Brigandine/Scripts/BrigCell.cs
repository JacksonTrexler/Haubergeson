using TbsFramework.Cells;
using UnityEngine;

namespace Lasjas.Brigandine{
    public class BrigCell : Square
    {
        //public string TileName;
        //public statblock statmod;
        //public statblock stats;

        Vector3 dimensions = new Vector3(2.5f, 2.5f, 0f);
        public override Vector3 GetCellDimensions()
        {
            return dimensions;
        }

        public override void MarkAsHighlighted()
        {
            GetComponent<Renderer>().material.color = new Color(0.75f, 0.75f, 0.75f);
        }

        public override void MarkAsPath()
        {
            GetComponent<Renderer>().material.color = Color.gray;
        }

        public override void MarkAsReachable()
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }

        public override void UnMark()
        {
            GetComponent<Renderer>().material.color = Color.white;
        }

    }

}
