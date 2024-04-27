namespace dotnetTemplate.Core.Interfaces;

public interface IUnitOfWork : IDisposable
{
    public void Save();
}