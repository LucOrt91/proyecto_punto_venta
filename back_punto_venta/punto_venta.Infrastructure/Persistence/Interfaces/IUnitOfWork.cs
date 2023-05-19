namespace punto_venta.Infrastructure.Persistence.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        //declaracion o matircula de interfaces a nivel de repository
        ICategoryRepository Category { get; }
        void SaveChances();
        Task SaveChancesAsync();
    }
}
