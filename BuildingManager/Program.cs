using BuildingManager.BusinessLogic;
using BuildingManager.Domain;

var builder = new BuildingBuilder();

Building building = builder
    .CreateBuilding("Hotel")
    .AddFloor(1)
        .AddRoom("Office")
        .AddRoom("Conference Hall")
        .AddRoom("Technical Room")
    .AddFloor(2)
        .AddRoom("Room 201")
        .AddRoom("Room 202")
        .AddRoom("Room 203")
    .AddFloor(3)
        .AddRoom("Room 301")
        .AddRoom("Room 302")
        .AddRoom("Room 303")
    .AddFloor(4)
        .AddRoom("Room 401")
        .AddRoom("Room 402")
        .AddRoom("Room 403")
    .AddFloor(5)
        .AddRoom("Room 501")
        .AddRoom("Room 502")
        .AddRoom("Room 503")
    .Build();

var buildingManager = new BuildingManagerService(building);

PrintHeader();

while (true)
{
    buildingManager.DisplayBuildingStructure();
}

void PrintHeader()
{
    Console.WriteLine("---Builder Manager App v0.1---");
    Console.WriteLine();
    Console.WriteLine("Tip: To navigate use arrow keys on keyboard. To exit press Ctrl+C");
    Console.WriteLine();
} 


