namespace BuildingManager.Domain
{
    public class Building : ILightOperation
    {
        public string Name { get; private set; }
        public bool IsLightOn { get; }

        public List<Floor> Floors { get; }

        public Building(string name)
        {
            Name = name;
            Floors = new List<Floor>();
        }

        public void AddFloor(Floor floor)
        {
            Floors.Add(floor);
        }
        public void TurnOnLights()
        {
            Console.WriteLine($"Light is ON in {Name} building");
            foreach (var floor in Floors)
            {
                floor.TurnOnLights();
            }
        }
        public void TurnOffLights()
        {
            Console.WriteLine($"Light is OFF in {Name} building");
            foreach (var floor in Floors)
            {
                floor.TurnOffLights();
            }
        }

        public override string ToString()
        {
            return $"Building - {Name}";
        }
    }

}