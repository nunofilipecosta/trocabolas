
namespace TrocaBolas.Infrastructure.Services
{
    using System;
    using Database;

    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly TrocaBolasContext _context;

        //public  UsersRepository { get; set; }

        public UnitOfWork(TrocaBolasContext context)
        {
            this._context = context;
        }

        public UnitOfWork()
        {
            _context = new TrocaBolasContext();
        }

        public void Save()
        {
            _context.Save();
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
                // TODO: Managed cleanup code here, while managed refs still valid
                _context.Dispose();
            }

            // TODO: Unmanaged cleanup code here
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
