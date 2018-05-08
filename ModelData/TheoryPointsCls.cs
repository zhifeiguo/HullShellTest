using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HullShellTest.ModelData
{
    public class TheoryPointsCls
    {

        public TheoryPointsCls()
        {
             ExcessPointsList=new List<PointCls>();
             EdgeEdgePointsList = new List<PointCls>(); ;
             PointsCloudList = new List<PointCls>(); ;
             RiblinePointsList = new List<PointCls>(); ;
        }

        private int _Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private int _RowNumber;
        public int RowNumberow
        {
            get { return _RowNumber; }
            set { _RowNumber = value; }
        }

        private int _ColnumNumber;
        public int ColnumNumber
        {
            get { return _ColnumNumber; }
            set { _ColnumNumber = value; }
        }

        public List<PointCls> ExcessPointsList;
        public List<PointCls> EdgeEdgePointsList;
        public List<PointCls> PointsCloudList;
        public List<PointCls> RiblinePointsList;

    }
}
