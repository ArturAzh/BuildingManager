namespace BuildingManager.Domain
{
    public interface IReserveOperation
    {
        public bool IsReserved { get; }
        public void Reserve();
        public void Cancel();
    }
}
