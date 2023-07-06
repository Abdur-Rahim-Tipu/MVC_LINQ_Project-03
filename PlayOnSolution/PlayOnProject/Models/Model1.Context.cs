﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PlayOnProject.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ProductDbEntities : DbContext
    {
        public ProductDbEntities()
            : base("name=ProductDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<purchase> purchases { get; set; }
    
        public virtual ObjectResult<Product> SelectSingleProduct(Nullable<int> i)
        {
            var iParameter = i.HasValue ?
                new ObjectParameter("i", i) :
                new ObjectParameter("i", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Product>("SelectSingleProduct", iParameter);
        }
    
        public virtual ObjectResult<Product> SelectSingleProduct(Nullable<int> i, MergeOption mergeOption)
        {
            var iParameter = i.HasValue ?
                new ObjectParameter("i", i) :
                new ObjectParameter("i", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Product>("SelectSingleProduct", mergeOption, iParameter);
        }
    
        public virtual ObjectResult<SPAlldata_Result> SPAlldata(Nullable<int> i)
        {
            var iParameter = i.HasValue ?
                new ObjectParameter("i", i) :
                new ObjectParameter("i", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SPAlldata_Result>("SPAlldata", iParameter);
        }
    
        public virtual ObjectResult<Customer> SpdeleteCustomer(Nullable<int> i)
        {
            var iParameter = i.HasValue ?
                new ObjectParameter("i", i) :
                new ObjectParameter("i", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Customer>("SpdeleteCustomer", iParameter);
        }
    
        public virtual ObjectResult<Customer> SpdeleteCustomer(Nullable<int> i, MergeOption mergeOption)
        {
            var iParameter = i.HasValue ?
                new ObjectParameter("i", i) :
                new ObjectParameter("i", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Customer>("SpdeleteCustomer", mergeOption, iParameter);
        }
    
        public virtual ObjectResult<Order> SpDeleteOrder(Nullable<int> i)
        {
            var iParameter = i.HasValue ?
                new ObjectParameter("i", i) :
                new ObjectParameter("i", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Order>("SpDeleteOrder", iParameter);
        }
    
        public virtual ObjectResult<Order> SpDeleteOrder(Nullable<int> i, MergeOption mergeOption)
        {
            var iParameter = i.HasValue ?
                new ObjectParameter("i", i) :
                new ObjectParameter("i", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Order>("SpDeleteOrder", mergeOption, iParameter);
        }
    
        public virtual ObjectResult<Product> SpdeleteProduct(Nullable<int> i)
        {
            var iParameter = i.HasValue ?
                new ObjectParameter("i", i) :
                new ObjectParameter("i", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Product>("SpdeleteProduct", iParameter);
        }
    
        public virtual ObjectResult<Product> SpdeleteProduct(Nullable<int> i, MergeOption mergeOption)
        {
            var iParameter = i.HasValue ?
                new ObjectParameter("i", i) :
                new ObjectParameter("i", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Product>("SpdeleteProduct", mergeOption, iParameter);
        }
    
        public virtual ObjectResult<purchase> SpDeletepurchase(Nullable<int> i)
        {
            var iParameter = i.HasValue ?
                new ObjectParameter("i", i) :
                new ObjectParameter("i", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<purchase>("SpDeletepurchase", iParameter);
        }
    
        public virtual ObjectResult<purchase> SpDeletepurchase(Nullable<int> i, MergeOption mergeOption)
        {
            var iParameter = i.HasValue ?
                new ObjectParameter("i", i) :
                new ObjectParameter("i", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<purchase>("SpDeletepurchase", mergeOption, iParameter);
        }
    
        public virtual ObjectResult<Customer> SpEditCustomer(Nullable<int> i, string n, string e, string p, string a)
        {
            var iParameter = i.HasValue ?
                new ObjectParameter("i", i) :
                new ObjectParameter("i", typeof(int));
    
            var nParameter = n != null ?
                new ObjectParameter("n", n) :
                new ObjectParameter("n", typeof(string));
    
            var eParameter = e != null ?
                new ObjectParameter("e", e) :
                new ObjectParameter("e", typeof(string));
    
            var pParameter = p != null ?
                new ObjectParameter("p", p) :
                new ObjectParameter("p", typeof(string));
    
            var aParameter = a != null ?
                new ObjectParameter("a", a) :
                new ObjectParameter("a", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Customer>("SpEditCustomer", iParameter, nParameter, eParameter, pParameter, aParameter);
        }
    
        public virtual ObjectResult<Customer> SpEditCustomer(Nullable<int> i, string n, string e, string p, string a, MergeOption mergeOption)
        {
            var iParameter = i.HasValue ?
                new ObjectParameter("i", i) :
                new ObjectParameter("i", typeof(int));
    
            var nParameter = n != null ?
                new ObjectParameter("n", n) :
                new ObjectParameter("n", typeof(string));
    
            var eParameter = e != null ?
                new ObjectParameter("e", e) :
                new ObjectParameter("e", typeof(string));
    
            var pParameter = p != null ?
                new ObjectParameter("p", p) :
                new ObjectParameter("p", typeof(string));
    
            var aParameter = a != null ?
                new ObjectParameter("a", a) :
                new ObjectParameter("a", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Customer>("SpEditCustomer", mergeOption, iParameter, nParameter, eParameter, pParameter, aParameter);
        }
    
        public virtual ObjectResult<Order> SpEditOrder(Nullable<int> i, Nullable<int> ci, Nullable<int> pi, Nullable<decimal> p, Nullable<int> q, Nullable<System.DateTime> od)
        {
            var iParameter = i.HasValue ?
                new ObjectParameter("i", i) :
                new ObjectParameter("i", typeof(int));
    
            var ciParameter = ci.HasValue ?
                new ObjectParameter("ci", ci) :
                new ObjectParameter("ci", typeof(int));
    
            var piParameter = pi.HasValue ?
                new ObjectParameter("pi", pi) :
                new ObjectParameter("pi", typeof(int));
    
            var pParameter = p.HasValue ?
                new ObjectParameter("p", p) :
                new ObjectParameter("p", typeof(decimal));
    
            var qParameter = q.HasValue ?
                new ObjectParameter("q", q) :
                new ObjectParameter("q", typeof(int));
    
            var odParameter = od.HasValue ?
                new ObjectParameter("od", od) :
                new ObjectParameter("od", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Order>("SpEditOrder", iParameter, ciParameter, piParameter, pParameter, qParameter, odParameter);
        }
    
        public virtual ObjectResult<Order> SpEditOrder(Nullable<int> i, Nullable<int> ci, Nullable<int> pi, Nullable<decimal> p, Nullable<int> q, Nullable<System.DateTime> od, MergeOption mergeOption)
        {
            var iParameter = i.HasValue ?
                new ObjectParameter("i", i) :
                new ObjectParameter("i", typeof(int));
    
            var ciParameter = ci.HasValue ?
                new ObjectParameter("ci", ci) :
                new ObjectParameter("ci", typeof(int));
    
            var piParameter = pi.HasValue ?
                new ObjectParameter("pi", pi) :
                new ObjectParameter("pi", typeof(int));
    
            var pParameter = p.HasValue ?
                new ObjectParameter("p", p) :
                new ObjectParameter("p", typeof(decimal));
    
            var qParameter = q.HasValue ?
                new ObjectParameter("q", q) :
                new ObjectParameter("q", typeof(int));
    
            var odParameter = od.HasValue ?
                new ObjectParameter("od", od) :
                new ObjectParameter("od", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Order>("SpEditOrder", mergeOption, iParameter, ciParameter, piParameter, pParameter, qParameter, odParameter);
        }
    
        public virtual ObjectResult<Product> SpEditProduct(Nullable<int> i, string n, string c, Nullable<decimal> p, Nullable<int> s, Nullable<System.DateTime> md, string pic)
        {
            var iParameter = i.HasValue ?
                new ObjectParameter("i", i) :
                new ObjectParameter("i", typeof(int));
    
            var nParameter = n != null ?
                new ObjectParameter("n", n) :
                new ObjectParameter("n", typeof(string));
    
            var cParameter = c != null ?
                new ObjectParameter("c", c) :
                new ObjectParameter("c", typeof(string));
    
            var pParameter = p.HasValue ?
                new ObjectParameter("p", p) :
                new ObjectParameter("p", typeof(decimal));
    
            var sParameter = s.HasValue ?
                new ObjectParameter("s", s) :
                new ObjectParameter("s", typeof(int));
    
            var mdParameter = md.HasValue ?
                new ObjectParameter("md", md) :
                new ObjectParameter("md", typeof(System.DateTime));
    
            var picParameter = pic != null ?
                new ObjectParameter("pic", pic) :
                new ObjectParameter("pic", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Product>("SpEditProduct", iParameter, nParameter, cParameter, pParameter, sParameter, mdParameter, picParameter);
        }
    
        public virtual ObjectResult<Product> SpEditProduct(Nullable<int> i, string n, string c, Nullable<decimal> p, Nullable<int> s, Nullable<System.DateTime> md, string pic, MergeOption mergeOption)
        {
            var iParameter = i.HasValue ?
                new ObjectParameter("i", i) :
                new ObjectParameter("i", typeof(int));
    
            var nParameter = n != null ?
                new ObjectParameter("n", n) :
                new ObjectParameter("n", typeof(string));
    
            var cParameter = c != null ?
                new ObjectParameter("c", c) :
                new ObjectParameter("c", typeof(string));
    
            var pParameter = p.HasValue ?
                new ObjectParameter("p", p) :
                new ObjectParameter("p", typeof(decimal));
    
            var sParameter = s.HasValue ?
                new ObjectParameter("s", s) :
                new ObjectParameter("s", typeof(int));
    
            var mdParameter = md.HasValue ?
                new ObjectParameter("md", md) :
                new ObjectParameter("md", typeof(System.DateTime));
    
            var picParameter = pic != null ?
                new ObjectParameter("pic", pic) :
                new ObjectParameter("pic", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Product>("SpEditProduct", mergeOption, iParameter, nParameter, cParameter, pParameter, sParameter, mdParameter, picParameter);
        }
    
        public virtual ObjectResult<purchase> SpEditpurchase(Nullable<int> i, Nullable<System.DateTime> pd, Nullable<int> q, Nullable<decimal> p, Nullable<int> pi)
        {
            var iParameter = i.HasValue ?
                new ObjectParameter("i", i) :
                new ObjectParameter("i", typeof(int));
    
            var pdParameter = pd.HasValue ?
                new ObjectParameter("pd", pd) :
                new ObjectParameter("pd", typeof(System.DateTime));
    
            var qParameter = q.HasValue ?
                new ObjectParameter("q", q) :
                new ObjectParameter("q", typeof(int));
    
            var pParameter = p.HasValue ?
                new ObjectParameter("p", p) :
                new ObjectParameter("p", typeof(decimal));
    
            var piParameter = pi.HasValue ?
                new ObjectParameter("pi", pi) :
                new ObjectParameter("pi", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<purchase>("SpEditpurchase", iParameter, pdParameter, qParameter, pParameter, piParameter);
        }
    
        public virtual ObjectResult<purchase> SpEditpurchase(Nullable<int> i, Nullable<System.DateTime> pd, Nullable<int> q, Nullable<decimal> p, Nullable<int> pi, MergeOption mergeOption)
        {
            var iParameter = i.HasValue ?
                new ObjectParameter("i", i) :
                new ObjectParameter("i", typeof(int));
    
            var pdParameter = pd.HasValue ?
                new ObjectParameter("pd", pd) :
                new ObjectParameter("pd", typeof(System.DateTime));
    
            var qParameter = q.HasValue ?
                new ObjectParameter("q", q) :
                new ObjectParameter("q", typeof(int));
    
            var pParameter = p.HasValue ?
                new ObjectParameter("p", p) :
                new ObjectParameter("p", typeof(decimal));
    
            var piParameter = pi.HasValue ?
                new ObjectParameter("pi", pi) :
                new ObjectParameter("pi", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<purchase>("SpEditpurchase", mergeOption, iParameter, pdParameter, qParameter, pParameter, piParameter);
        }
    
        public virtual ObjectResult<Customer> SpInsertCustomer(string n, string e, string p, string a)
        {
            var nParameter = n != null ?
                new ObjectParameter("n", n) :
                new ObjectParameter("n", typeof(string));
    
            var eParameter = e != null ?
                new ObjectParameter("e", e) :
                new ObjectParameter("e", typeof(string));
    
            var pParameter = p != null ?
                new ObjectParameter("p", p) :
                new ObjectParameter("p", typeof(string));
    
            var aParameter = a != null ?
                new ObjectParameter("a", a) :
                new ObjectParameter("a", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Customer>("SpInsertCustomer", nParameter, eParameter, pParameter, aParameter);
        }
    
        public virtual ObjectResult<Customer> SpInsertCustomer(string n, string e, string p, string a, MergeOption mergeOption)
        {
            var nParameter = n != null ?
                new ObjectParameter("n", n) :
                new ObjectParameter("n", typeof(string));
    
            var eParameter = e != null ?
                new ObjectParameter("e", e) :
                new ObjectParameter("e", typeof(string));
    
            var pParameter = p != null ?
                new ObjectParameter("p", p) :
                new ObjectParameter("p", typeof(string));
    
            var aParameter = a != null ?
                new ObjectParameter("a", a) :
                new ObjectParameter("a", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Customer>("SpInsertCustomer", mergeOption, nParameter, eParameter, pParameter, aParameter);
        }
    
        public virtual ObjectResult<Order> SpInsertOrder(Nullable<int> ci, Nullable<int> pi, Nullable<decimal> p, Nullable<int> q, Nullable<System.DateTime> od)
        {
            var ciParameter = ci.HasValue ?
                new ObjectParameter("ci", ci) :
                new ObjectParameter("ci", typeof(int));
    
            var piParameter = pi.HasValue ?
                new ObjectParameter("pi", pi) :
                new ObjectParameter("pi", typeof(int));
    
            var pParameter = p.HasValue ?
                new ObjectParameter("p", p) :
                new ObjectParameter("p", typeof(decimal));
    
            var qParameter = q.HasValue ?
                new ObjectParameter("q", q) :
                new ObjectParameter("q", typeof(int));
    
            var odParameter = od.HasValue ?
                new ObjectParameter("od", od) :
                new ObjectParameter("od", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Order>("SpInsertOrder", ciParameter, piParameter, pParameter, qParameter, odParameter);
        }
    
        public virtual ObjectResult<Order> SpInsertOrder(Nullable<int> ci, Nullable<int> pi, Nullable<decimal> p, Nullable<int> q, Nullable<System.DateTime> od, MergeOption mergeOption)
        {
            var ciParameter = ci.HasValue ?
                new ObjectParameter("ci", ci) :
                new ObjectParameter("ci", typeof(int));
    
            var piParameter = pi.HasValue ?
                new ObjectParameter("pi", pi) :
                new ObjectParameter("pi", typeof(int));
    
            var pParameter = p.HasValue ?
                new ObjectParameter("p", p) :
                new ObjectParameter("p", typeof(decimal));
    
            var qParameter = q.HasValue ?
                new ObjectParameter("q", q) :
                new ObjectParameter("q", typeof(int));
    
            var odParameter = od.HasValue ?
                new ObjectParameter("od", od) :
                new ObjectParameter("od", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Order>("SpInsertOrder", mergeOption, ciParameter, piParameter, pParameter, qParameter, odParameter);
        }
    
        public virtual ObjectResult<Product> SpInsertProduct(string n, string c, Nullable<decimal> p, Nullable<int> s, Nullable<System.DateTime> md, string pic)
        {
            var nParameter = n != null ?
                new ObjectParameter("n", n) :
                new ObjectParameter("n", typeof(string));
    
            var cParameter = c != null ?
                new ObjectParameter("c", c) :
                new ObjectParameter("c", typeof(string));
    
            var pParameter = p.HasValue ?
                new ObjectParameter("p", p) :
                new ObjectParameter("p", typeof(decimal));
    
            var sParameter = s.HasValue ?
                new ObjectParameter("s", s) :
                new ObjectParameter("s", typeof(int));
    
            var mdParameter = md.HasValue ?
                new ObjectParameter("md", md) :
                new ObjectParameter("md", typeof(System.DateTime));
    
            var picParameter = pic != null ?
                new ObjectParameter("pic", pic) :
                new ObjectParameter("pic", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Product>("SpInsertProduct", nParameter, cParameter, pParameter, sParameter, mdParameter, picParameter);
        }
    
        public virtual ObjectResult<Product> SpInsertProduct(string n, string c, Nullable<decimal> p, Nullable<int> s, Nullable<System.DateTime> md, string pic, MergeOption mergeOption)
        {
            var nParameter = n != null ?
                new ObjectParameter("n", n) :
                new ObjectParameter("n", typeof(string));
    
            var cParameter = c != null ?
                new ObjectParameter("c", c) :
                new ObjectParameter("c", typeof(string));
    
            var pParameter = p.HasValue ?
                new ObjectParameter("p", p) :
                new ObjectParameter("p", typeof(decimal));
    
            var sParameter = s.HasValue ?
                new ObjectParameter("s", s) :
                new ObjectParameter("s", typeof(int));
    
            var mdParameter = md.HasValue ?
                new ObjectParameter("md", md) :
                new ObjectParameter("md", typeof(System.DateTime));
    
            var picParameter = pic != null ?
                new ObjectParameter("pic", pic) :
                new ObjectParameter("pic", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Product>("SpInsertProduct", mergeOption, nParameter, cParameter, pParameter, sParameter, mdParameter, picParameter);
        }
    
        public virtual ObjectResult<purchase> SpInsertpurchase(Nullable<System.DateTime> pd, Nullable<int> q, Nullable<decimal> p, Nullable<int> pi)
        {
            var pdParameter = pd.HasValue ?
                new ObjectParameter("pd", pd) :
                new ObjectParameter("pd", typeof(System.DateTime));
    
            var qParameter = q.HasValue ?
                new ObjectParameter("q", q) :
                new ObjectParameter("q", typeof(int));
    
            var pParameter = p.HasValue ?
                new ObjectParameter("p", p) :
                new ObjectParameter("p", typeof(decimal));
    
            var piParameter = pi.HasValue ?
                new ObjectParameter("pi", pi) :
                new ObjectParameter("pi", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<purchase>("SpInsertpurchase", pdParameter, qParameter, pParameter, piParameter);
        }
    
        public virtual ObjectResult<purchase> SpInsertpurchase(Nullable<System.DateTime> pd, Nullable<int> q, Nullable<decimal> p, Nullable<int> pi, MergeOption mergeOption)
        {
            var pdParameter = pd.HasValue ?
                new ObjectParameter("pd", pd) :
                new ObjectParameter("pd", typeof(System.DateTime));
    
            var qParameter = q.HasValue ?
                new ObjectParameter("q", q) :
                new ObjectParameter("q", typeof(int));
    
            var pParameter = p.HasValue ?
                new ObjectParameter("p", p) :
                new ObjectParameter("p", typeof(decimal));
    
            var piParameter = pi.HasValue ?
                new ObjectParameter("pi", pi) :
                new ObjectParameter("pi", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<purchase>("SpInsertpurchase", mergeOption, pdParameter, qParameter, pParameter, piParameter);
        }
    
        public virtual ObjectResult<Order> SpOrderWithPC(Nullable<int> i)
        {
            var iParameter = i.HasValue ?
                new ObjectParameter("i", i) :
                new ObjectParameter("i", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Order>("SpOrderWithPC", iParameter);
        }
    
        public virtual ObjectResult<Order> SpOrderWithPC(Nullable<int> i, MergeOption mergeOption)
        {
            var iParameter = i.HasValue ?
                new ObjectParameter("i", i) :
                new ObjectParameter("i", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Order>("SpOrderWithPC", mergeOption, iParameter);
        }
    
        public virtual ObjectResult<Customer> SpSelectAllCustomers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Customer>("SpSelectAllCustomers");
        }
    
        public virtual ObjectResult<Customer> SpSelectAllCustomers(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Customer>("SpSelectAllCustomers", mergeOption);
        }
    
        public virtual ObjectResult<Order> SpSelectAllOrder()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Order>("SpSelectAllOrder");
        }
    
        public virtual ObjectResult<Order> SpSelectAllOrder(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Order>("SpSelectAllOrder", mergeOption);
        }
    
        public virtual ObjectResult<Product> SpSelectAllProducts()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Product>("SpSelectAllProducts");
        }
    
        public virtual ObjectResult<Product> SpSelectAllProducts(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Product>("SpSelectAllProducts", mergeOption);
        }
    
        public virtual ObjectResult<purchase> SpSelectAllpurchases()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<purchase>("SpSelectAllpurchases");
        }
    
        public virtual ObjectResult<purchase> SpSelectAllpurchases(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<purchase>("SpSelectAllpurchases", mergeOption);
        }
    
        public virtual ObjectResult<Customer> SpSelectSingleCustomer(Nullable<int> i)
        {
            var iParameter = i.HasValue ?
                new ObjectParameter("i", i) :
                new ObjectParameter("i", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Customer>("SpSelectSingleCustomer", iParameter);
        }
    
        public virtual ObjectResult<Customer> SpSelectSingleCustomer(Nullable<int> i, MergeOption mergeOption)
        {
            var iParameter = i.HasValue ?
                new ObjectParameter("i", i) :
                new ObjectParameter("i", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Customer>("SpSelectSingleCustomer", mergeOption, iParameter);
        }
    
        public virtual ObjectResult<Order> SpSelectSingleOrder(Nullable<int> i)
        {
            var iParameter = i.HasValue ?
                new ObjectParameter("i", i) :
                new ObjectParameter("i", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Order>("SpSelectSingleOrder", iParameter);
        }
    
        public virtual ObjectResult<Order> SpSelectSingleOrder(Nullable<int> i, MergeOption mergeOption)
        {
            var iParameter = i.HasValue ?
                new ObjectParameter("i", i) :
                new ObjectParameter("i", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Order>("SpSelectSingleOrder", mergeOption, iParameter);
        }
    }
}
