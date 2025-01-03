using UnityEngine;

public class OVRObjectPlacer : MonoBehaviour
{
    public GameObject objectToPlace;  // The object prefab to place
    public OVRInput.Controller controller = OVRInput.Controller.RTouch; // Right controller
    public LayerMask placementLayer; // Valid surfaces for placement
    public Transform rayOrigin;      // Ray origin (optional, can use controller directly)

    private GameObject placedObject;
    private RaycastHit hitInfo;

    void Update()
    {
        // Check if the trigger is pressed
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, controller))
        {
            PerformPlacement();
        }
    }

    void PerformPlacement()
    {
        // Perform raycast from the controller
        Vector3 origin = rayOrigin != null ? rayOrigin.position : OVRInput.GetLocalControllerPosition(controller);
        Vector3 direction = rayOrigin != null ? rayOrigin.forward : OVRInput.GetLocalControllerRotation(controller) * Vector3.forward;

        if (Physics.Raycast(origin, direction, out hitInfo, 100f, placementLayer))
        {
            if (placedObject == null)
            {
                // Instantiate the object if it hasn't been placed yet
                placedObject = Instantiate(objectToPlace, hitInfo.point, Quaternion.identity);
            }
            else
            {
                // Move the object to the new hit location
                placedObject.transform.position = hitInfo.point;
            }
        }
    }
}
