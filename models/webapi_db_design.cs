using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace appglobal
{	
    public class m_bulan
	{
		public int m_bulan_id { get; set; }
		public string m_bulan_nama { get; set; }
	}
   
    public class webapi_db : DbContext
    {
        public DbSet<m_bulan> m_bulan {get; set;}

        public webapi_db(DbContextOptions<webapi_db> options) :
            base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder opt)
        {
            #region m_bulan
            opt.Entity<m_bulan>()
               .HasKey(e => e.m_bulan_id);

            opt.Entity<m_bulan>()
               .Property(e => e.m_bulan_id)
			   .IsRequired()
			   .ValueGeneratedNever();

            opt.Entity<m_bulan>()
               .Property(e => e.m_bulan_nama)
               .HasMaxLength(10);
            #endregion
        }
        
    }
}