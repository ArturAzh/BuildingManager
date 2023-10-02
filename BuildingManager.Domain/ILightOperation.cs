namespace BuildingManager.Domain
{
    public interface ILightOperation
    {
        public bool IsLightOn { get; }
        public void TurnOnLights();
        public void TurnOffLights();
    }
}
