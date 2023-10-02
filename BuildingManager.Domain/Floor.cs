namespace BuildingManager.Domain
{
    public class Floor : ILightOperation
    {
        public int Id { get; private set; }
        public bool IsLightOn { get; }

        public List<Room> Rooms { get; }

        public Floor(int id)
        {
            Id = id;
            Rooms = new List<Room>();
        }

        public void AddRoom(Room room)
        {
            Rooms.Add(room);
        }
        public void TurnOnLights()
        {
            Console.WriteLine($"Light is ON in {Id} floor");
            foreach (var room in Rooms)
            {
                room.TurnOnLights();
            }
        }
        public void TurnOffLights()
        {
            Console.WriteLine($"Light is OFF in {Id} floor");
            foreach (var room in Rooms)
            {
                room.TurnOffLights();
            }
        }

        public override string ToString()
        {
            return $"   Floor {Id}";
        }
    }
}
