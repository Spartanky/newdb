//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace newdb.Models.DataEntityModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entity_DB : DbContext
    {
        public Entity_DB()
            : base("name=Entity_DB")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Builds> Builds { get; set; }
        public virtual DbSet<crate> crate { get; set; }
        public virtual DbSet<Data> Data { get; set; }
        public virtual DbSet<Detals> Detals { get; set; }
        public virtual DbSet<HistoryDates> HistoryDates { get; set; }
        public virtual DbSet<Keys_Users> Keys_Users { get; set; }
        public virtual DbSet<List_Builds> List_Builds { get; set; }
        public virtual DbSet<Raz> Raz { get; set; }
        public virtual DbSet<Zakaz> Zakaz { get; set; }
    }
}
