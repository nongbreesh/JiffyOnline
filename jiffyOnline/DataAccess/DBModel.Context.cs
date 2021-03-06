﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace jiffyOnline.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class JIFFY_DBEntities : DbContext
    {
        public JIFFY_DBEntities()
            : base("name=JIFFY_DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<T_AMPHUR> T_AMPHUR { get; set; }
        public DbSet<T_AMPHUR_POSTCODE> T_AMPHUR_POSTCODE { get; set; }
        public DbSet<T_BANNER> T_BANNER { get; set; }
        public DbSet<T_BRAND> T_BRAND { get; set; }
        public DbSet<T_CATEGORIES> T_CATEGORIES { get; set; }
        public DbSet<T_CATEGORIES_ATT> T_CATEGORIES_ATT { get; set; }
        public DbSet<T_CONTENT> T_CONTENT { get; set; }
        public DbSet<T_CUSTOMER> T_CUSTOMER { get; set; }
        public DbSet<T_CUSTOMER_GROUP> T_CUSTOMER_GROUP { get; set; }
        public DbSet<T_DISTRICT> T_DISTRICT { get; set; }
        public DbSet<T_IMAGE> T_IMAGE { get; set; }
        public DbSet<T_ORDER> T_ORDER { get; set; }
        public DbSet<T_ORDERCART> T_ORDERCART { get; set; }
        public DbSet<T_PRODUCT_RELATION> T_PRODUCT_RELATION { get; set; }
        public DbSet<T_PRODUCT_TIER_PRICE> T_PRODUCT_TIER_PRICE { get; set; }
        public DbSet<T_PRODUCTS> T_PRODUCTS { get; set; }
        public DbSet<T_PRODUCTS_ATT> T_PRODUCTS_ATT { get; set; }
        public DbSet<T_PROGRAM> T_PROGRAM { get; set; }
        public DbSet<T_PROMOTION> T_PROMOTION { get; set; }
        public DbSet<T_PROMOTION_CONDITION> T_PROMOTION_CONDITION { get; set; }
        public DbSet<T_PROVINCE> T_PROVINCE { get; set; }
        public DbSet<T_ROLE> T_ROLE { get; set; }
        public DbSet<T_SHIPPINGMETHOD> T_SHIPPINGMETHOD { get; set; }
        public DbSet<T_STORE> T_STORE { get; set; }
        public DbSet<T_USERS> T_USERS { get; set; }
        public DbSet<T_VENDOR> T_VENDOR { get; set; }
        public DbSet<T_WISHLIST> T_WISHLIST { get; set; }
        public DbSet<T_LOOKUP> T_LOOKUP { get; set; }
        public DbSet<T_ONHAND> T_ONHAND { get; set; }
        public DbSet<T_ROLE_D> T_ROLE_D { get; set; }
        public DbSet<T_PROMOTION_EXCLUDE> T_PROMOTION_EXCLUDE { get; set; }
        public DbSet<V_BANNER> V_BANNER { get; set; }
        public DbSet<V_CONTENT_TYPE> V_CONTENT_TYPE { get; set; }
        public DbSet<V_PRODUCT_CATAGORIES> V_PRODUCT_CATAGORIES { get; set; }
        public DbSet<V_PRODUCT_RELATION> V_PRODUCT_RELATION { get; set; }
        public DbSet<V_PRODUCTS> V_PRODUCTS { get; set; }
        public DbSet<V_PROMOTION_COND> V_PROMOTION_COND { get; set; }
        public DbSet<V_PROMOTION_EXCLUDE> V_PROMOTION_EXCLUDE { get; set; }
        public DbSet<V_ROLE_PROGRAM> V_ROLE_PROGRAM { get; set; }
        public DbSet<V_USER_ROLES> V_USER_ROLES { get; set; }
        public DbSet<RUNNING> RUNNINGs { get; set; }
    
        public virtual ObjectResult<P_CATEGORIES_LEVEL_Result> P_CATEGORIES_LEVEL(string cond)
        {
            var condParameter = cond != null ?
                new ObjectParameter("cond", cond) :
                new ObjectParameter("cond", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<P_CATEGORIES_LEVEL_Result>("P_CATEGORIES_LEVEL", condParameter);
        }
    
        public virtual ObjectResult<P_CATEGORIES_LOOKUP_Result> P_CATEGORIES_LOOKUP()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<P_CATEGORIES_LOOKUP_Result>("P_CATEGORIES_LOOKUP");
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    }
}
