using newdb.Models.DataEntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newdb.Models.Base
{
    public abstract class BaseModelEntity<T>
    {
        protected Entity_DB db = new Entity_DB();

        public abstract void AddEntity(T entity);

        public abstract void UpdEntity(T entity);

        public abstract void DelEntity(Object pk);

        public abstract List<T> GetEntitties();

        public abstract T GetEntity(Object pk);
    }
}
