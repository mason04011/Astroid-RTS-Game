using UnityEngine;
using UnityEngine.EventSystems;

public class BuildingPlacer : MonoBehaviour
{
    private UIManager _uiManager;

    private Building _placedBuilding = null;
    private Ray _ray;
    private RaycastHit _raycastHit;
    private Vector3 _lastPlacementPosition;

        
  

    void Update()
    {
        if (_placedBuilding != null)
        {
            if (Input.GetKeyUp(KeyCode.Escape))
            {
                _CancelPlacedBuilding();
                return;
            }

            // ... do the raycast
            _ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(
                _ray,
                out _raycastHit,
                1000f,
                Globals.TERRAIN_LAYER_MASK
            ))
            {
                _placedBuilding.SetPosition(_raycastHit.point);
                if (_lastPlacementPosition != _raycastHit.point)
                {
                    _placedBuilding.CheckValidPlacement();
                }
                _lastPlacementPosition = _raycastHit.point;
            }

            if (
                _placedBuilding.HasValidPlacement &&
                Input.GetMouseButtonDown(0) &&
                !EventSystem.current.IsPointerOverGameObject()
            )
            {
                _PlaceBuilding();
            }
        }
        }
    private void Awake()
    {
        _uiManager = GetComponent<UIManager>();
    }

    void _PreparePlacedBuilding(int buildingDataIndex)
    {
        Building building = new Building(
            Globals.BUILDING_DATA[buildingDataIndex]
        );
        // link the data into the manager
        building.Transform.GetComponent<BuildingManager>().Initialize(building);
        _placedBuilding = building;
        _lastPlacementPosition = Vector3.zero;
    }
    void _PlaceBuilding()
    {
        _placedBuilding.Place();
        // keep on building the same building type
        _PreparePlacedBuilding(_placedBuilding.DataIndex);
       
    }
        void _CancelPlacedBuilding()
        {
            // destroy the "phantom" building
            Destroy(_placedBuilding.Transform.gameObject);
            _placedBuilding = null;
        }
        public void SelectPlacedBuilding(int buildingDataIndex)
        {
            _PreparePlacedBuilding(buildingDataIndex);
        }
        
    }
