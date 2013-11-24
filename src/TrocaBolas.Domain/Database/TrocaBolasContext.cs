
namespace TrocaBolas.Domain.Database
{
    using System;
    using System.Data.Entity;

    using TrocaBolas.Domain.Database.Mappings;
    using TrocaBolas.Domain.Entities;

    public class TrocaBolasContext : DbContext, IDbContext
    {
        public TrocaBolasContext()
            : base("umbracoDbDSN")
        {
        }

        public DbSet<TrocaBolasUserProfile> Profiles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // add mappings here
            modelBuilder.Configurations.Add(new TrocaBolasUserProfileMapping());
        }

        public void Save()
        {
            this.SaveChanges();
        }


        #region IDisposable Members

        /// <summary>
        /// Internal variable which checks if Dispose has already been called
        /// </summary>
        private Boolean disposed;

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        private void Dispose(Boolean disposing)
        {
            if (disposed)
            {
                return;
            }

            if (disposing)
            {
                //TODO: Managed cleanup code here, while managed refs still valid
            }
            //TODO: Unmanaged cleanup code here

            disposed = true;
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            // Call the private Dispose(bool) helper and indicate 
            // that we are explicitly disposing
            this.Dispose(true);

            // Tell the garbage collector that the object doesn't require any
            // cleanup when collected since Dispose was called explicitly.
            GC.SuppressFinalize(this);
        }

        #endregion
				
    }
}
