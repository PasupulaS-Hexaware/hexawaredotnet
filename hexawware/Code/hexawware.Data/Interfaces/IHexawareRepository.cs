using hexawware.Entities.Entities;


namespace hexawware.Data.Interfaces
{
    public interface IHexawareRepository : IGetById<Hexaware>, IGetAll<Hexaware>, ISave<Hexaware>, IUpdate<Hexaware>, IDelete<int>
    {
    }
}
