using dotnetTemplate.Core.Attributes;
using dotnetTemplate.Core.Interfaces;

namespace dotnetTemplate.Persistence;

[LogAndMeasure]
public class UnitOfWork : IUnitOfWork
{
    private bool _disposed = false;
    
    public void Save()
    {
        // If you are using Entity Framework:
        // context.SaveChanges();
    }

    private void Dispose(bool disposing)
    {
        if (!_disposed && disposing)
        {
            // If you are using Entity Framework:
            //context.Dispose();
        }
        
        _disposed = true;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}