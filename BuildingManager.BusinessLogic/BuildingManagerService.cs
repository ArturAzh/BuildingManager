using BuildingManager.Domain;
using Sharprompt;

namespace BuildingManager.BusinessLogic;

public class BuildingManagerService
{
    private Building _building;
    private List<object> _buildingItems;

    public BuildingManagerService(Building building)
    {
        _building = building;
        InitBuildingItems();
    }

    public void DisplayBuildingStructure()
    {
        //use existing Sharprompt package to arrange console interface
        var selectedBuildingItem = Prompt.Select($"Select building Item", _buildingItems);

        var subItems = GetSubItems(selectedBuildingItem);

        string subSelected = Prompt.Select($"Select operation", subItems.Keys);
        
        subItems[subSelected].Invoke();
    }

    private void InitBuildingItems()
    {
        _buildingItems = new List<object> { _building };

        foreach (var floor in _building.Floors)
        {
            _buildingItems.Add(floor);

            foreach (var room in floor.Rooms)
                _buildingItems.Add(room);
        }
    }

    private Dictionary<string, Action> GetSubItems(object selectedBuildingItem)
    {
        var subItems = new Dictionary<string, Action>();
        
        if (selectedBuildingItem is ILightOperation)
        {
            subItems.Add("Turn ON Lights", new Action(() => { ((ILightOperation)selectedBuildingItem).TurnOnLights(); }));
            subItems.Add("Turn OFF Lights", new Action(() => { ((ILightOperation)selectedBuildingItem).TurnOffLights(); }));
        }

        if (selectedBuildingItem is IReserveOperation)
        {
            subItems.Add("Book", new Action(() => { ((IReserveOperation)selectedBuildingItem).Reserve(); }));
            subItems.Add("Cancel Booking", new Action(() => { ((IReserveOperation)selectedBuildingItem).Cancel(); }));
        }

        return subItems;
    }

}




    