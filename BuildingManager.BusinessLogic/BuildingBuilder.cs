using BuildingManager.Domain;

namespace BuildingManager.BusinessLogic
{
    public class BuildingBuilder
    {
        private Building building;

        public BuildingBuilder CreateBuilding(string name)
        {
            building = new Building(name);
            return this;
        }

        public BuildingBuilder AddFloor(int floorNumber)
        {
            var floor = new Floor(floorNumber);
            building.AddFloor(floor);
            return this;
        }

        public BuildingBuilder AddRoom(string roomName)
        {
            if (building.Floors.Count == 0)
            {
                AddFloor(1);
            }
            var room = new Room(roomName);
            building.Floors[building.Floors.Count - 1].AddRoom(room);
            return this;
        }

        public Building Build()
        {
            return building;
        }
    }
}
