namespace BuildingManager.Domain
{
    public class Room : ILightOperation, IReserveOperation
    {
        public bool IsLightOn { get; private set; }

        public bool IsReserved { get; private set; }

        public readonly string Name;
        public Room(string name)
        {
            Name = name;
        }

        public void TurnOffLights()
        {
            if (IsLightOn)
            {
                IsLightOn = false;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Light is OFF in {Name} room");
                Console.ResetColor();
            }
        }

        public void TurnOnLights()
        {
            if (IsLightOn == false)
            {
                IsLightOn = true;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Light is ON in {Name} room");
                Console.ResetColor();
            }
        }

        public void Reserve()
        {
            if (IsReserved == false)
            {
                IsReserved = true;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"{Name} room is Reserved");
                Console.ResetColor();
            }
        }

        public void Cancel()
        {
            if (IsReserved == false)
            {
                IsReserved = true;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"For {Name} room reservation is cancled");
                Console.ResetColor();
            }
        }

        public override string ToString()
        {
            return $"       {Name}";
        }
    }
}
