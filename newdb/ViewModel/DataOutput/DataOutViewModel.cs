using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using newdb.Models.Base;
using newdb.Models.DataEntityModel;

namespace newdb.ViewModel.DataOutput
{
    internal class DataOutViewModel : ViewModel
    {
        public List<Data> Date
        {
            get
            {
                EventData EV = new EventData();
                List<Data> datas = EV.GetEntitties();
                List<Data> dt = datas.Where(i => i.Id > 100).ToList<Data>();
                return dt;
            }
        }
    }
}
