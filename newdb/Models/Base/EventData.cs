using newdb.Models.DataEntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newdb.Models.Base
{
    public class EventData : BaseModelEntity<Data>
    {
        public override void AddEntity(Data entity)
        {
            db.Data.Add(entity);
            db.SaveChanges();
        }

        public override void DelEntity(object pk)
        {
            Data data = db.Data.Where(i => i.Id == (int)pk).First<Data>();
            if(data == null)
            {
                throw new ArgumentException();
            }
            else
            {
                db.Data.Remove(data);
                db.SaveChanges();
            }
        }

        public override List<Data> GetEntitties()
        {
            return db.Data.ToList<Data>();
        }

        public override Data GetEntity(object pk)
        {
            return db.Data.Where(i => i.Id == (int)pk).First<Data>();
        }

        public override void UpdEntity(Data entity)
        {
            Data data = db.Data.Where(i => i.Id == entity.Id).First<Data>();
            if(data == null)
            {
                throw new ArgumentException();
            }
            else
            {
                data.Build = entity.Build;
                data.Zakaz = entity.Zakaz;
                data.Detal = entity.Detal;
                data.Quantity = entity.Quantity;
                data.Date_del = entity.Date_del;
                data.Date_rec = entity.Date_rec;
                data.Comment = entity.Comment;
                data.Razov = entity.Razov;
                data.time_all_detal = entity.time_all_detal;
                data.time_one_detal = entity.time_one_detal;
                db.SaveChanges();
            }
        }
    }
}
