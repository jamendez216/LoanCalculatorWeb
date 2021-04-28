﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoanCalculatorDataAccess.DbContext
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Data.Entity.Core.Objects.DataClasses;
    using System.Linq;
    
    public partial class LoanCalculatorEntities : DbContext
    {
        public LoanCalculatorEntities()
            : base("name=LoanCalculatorEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<AGE_RATE> AGE_RATE { get; set; }
        public DbSet<AVAILABILITY_MONTHS> AVAILABILITY_MONTHS { get; set; }
        public DbSet<QUERY_LOG> QUERY_LOG { get; set; }
    
        public virtual decimal INSERT_QUERY_LOG(Nullable<int> aGE, Nullable<decimal> aMOUNT, Nullable<int> mONTHS, string uSER_LOG)
        {
            var aGEParameter = aGE.HasValue ?
                new ObjectParameter("AGE", aGE) :
                new ObjectParameter("AGE", typeof(int));
    
            var aMOUNTParameter = aMOUNT.HasValue ?
                new ObjectParameter("AMOUNT", aMOUNT) :
                new ObjectParameter("AMOUNT", typeof(decimal));
    
            var mONTHSParameter = mONTHS.HasValue ?
                new ObjectParameter("MONTHS", mONTHS) :
                new ObjectParameter("MONTHS", typeof(int));
    
            var uSER_LOGParameter = uSER_LOG != null ?
                new ObjectParameter("USER_LOG", uSER_LOG) :
                new ObjectParameter("USER_LOG", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("INSERT_QUERY_LOG", aGEParameter, aMOUNTParameter, mONTHSParameter, uSER_LOGParameter);
        }
    
        public virtual ObjectResult<QUERY_LOG> InsertLog(Nullable<int> aGE, Nullable<decimal> aMOUNT, Nullable<int> mONTHS, string uSER_LOG)
        {
            var aGEParameter = aGE.HasValue ?
                new ObjectParameter("AGE", aGE) :
                new ObjectParameter("AGE", typeof(int));
    
            var aMOUNTParameter = aMOUNT.HasValue ?
                new ObjectParameter("AMOUNT", aMOUNT) :
                new ObjectParameter("AMOUNT", typeof(decimal));
    
            var mONTHSParameter = mONTHS.HasValue ?
                new ObjectParameter("MONTHS", mONTHS) :
                new ObjectParameter("MONTHS", typeof(int));
    
            var uSER_LOGParameter = uSER_LOG != null ?
                new ObjectParameter("USER_LOG", uSER_LOG) :
                new ObjectParameter("USER_LOG", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<QUERY_LOG>("InsertLog", aGEParameter, aMOUNTParameter, mONTHSParameter, uSER_LOGParameter);
        }
    
        public virtual ObjectResult<QUERY_LOG> InsertLog(Nullable<int> aGE, Nullable<decimal> aMOUNT, Nullable<int> mONTHS, string uSER_LOG, MergeOption mergeOption)
        {
            var aGEParameter = aGE.HasValue ?
                new ObjectParameter("AGE", aGE) :
                new ObjectParameter("AGE", typeof(int));
    
            var aMOUNTParameter = aMOUNT.HasValue ?
                new ObjectParameter("AMOUNT", aMOUNT) :
                new ObjectParameter("AMOUNT", typeof(decimal));
    
            var mONTHSParameter = mONTHS.HasValue ?
                new ObjectParameter("MONTHS", mONTHS) :
                new ObjectParameter("MONTHS", typeof(int));
    
            var uSER_LOGParameter = uSER_LOG != null ?
                new ObjectParameter("USER_LOG", uSER_LOG) :
                new ObjectParameter("USER_LOG", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<QUERY_LOG>("InsertLog", mergeOption, aGEParameter, aMOUNTParameter, mONTHSParameter, uSER_LOGParameter);
        }
    }
}