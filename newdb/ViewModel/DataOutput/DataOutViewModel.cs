using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using newdb.Models.Base;
using newdb.Models.DataEntityModel;

namespace newdb.ViewModel.DataOutput
{
    internal class DataOutViewModel : ViewModel
    {
        private Int64 _Array;
        public Int64 Array
        {
            get => _Array;
            set => Set(ref _Array,value);
        }
        private List<Data> _Date;
        public List<Data> Date
        {
            get
            {
                EventData EV = new EventData();
                List<Data> datas = EV.GetEntitties();
                _Date = datas.Where(i => i.Id < 1000).ToList<Data>();
                return _Date;
            }
            set
            {
                EventData EV = new EventData();
                List<Data> datas = EV.GetEntitties();
                _Date = datas.Where(i => i.Id < Array).ToList<Data>();
                return;
            }
        }
    }
}
