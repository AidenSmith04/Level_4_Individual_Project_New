using UnityEngine;
using UnityEngine.EventSystems;

public class MetaObjectPlacer : MonoBehaviour
{
    public GameObject objectToPlacePrefab;  // The object that will be placed
    public float maxRayDistance = 10f;  // Maximum raycast distance
    public LayerMask placementLayer;  // Layer for valid placement surfaces
    private GameObject previewObject;  // Preview object that follows the ray

    private OVRInput.Button placementButton = OVRInput.Button.PrimaryIndexTrigger;  // Button to place the object (e.g., trigger button)

    void Update()
    {
        // Create a ray based on the current controller position and direction
        Ray ray = new Ray(transform.position, transform.forward);

        // Cast a ray using RaycastAll to check for both UI and world interactions
        RaycastHit[] hits = Physics.RaycastAll(ray, maxRayDistance, placementLayer);

        // Check if the raycast hits a UI element first (using EventSystem)
        PointerEventData pointerEventData = new PointerEventData(EventSystem.current)
        {
            position = new Vector2(Screen.width / 2, Screen.height / 2)  // Assuming the raycast is in the center of the screen
        };

        // Raycast against all UI elements
        var results = new System.Collections.Generic.List<RaycastResult>();
        EventSystem.current.RaycastAll(pointerEventData, results);

        if (results.Count > 0)
        {
            // Ray is hitting a UI element, so ignore placing objects
            Debug.Log("Raycast hit a UI element. Ignoring world placement.");
            return;
        }

        // If no UI element is hit, we proceed to check world placement
        if (hits.Length > 0)
        {
            RaycastHit hit = hits[0]; // Take the first hit (you can improve this logic to pick the closest hit)
            Debug.Log("Raycast Hit (World): " + hit.point);

            // If there's no preview object, create one
            if (previewObject == null)
            {
                previewObject = Instantiate(objectToPlacePrefab, hit.point, Quaternion.identity);
                previewObject.GetComponent<Renderer>().material.color = Color.green;  // Visual feedback for valid placement
            }
            else
            {
                // Update the preview object's position to follow the raycast hit
                previewObject.transform.position = hit.point;
            }

            // Handle object placement when the button is pressed
            if (OVRInput.GetDown(placementButton))
            {
                PlaceObject(hit.point);
            }
        }
        else
        {
            Debug.Log("Raycast Missed (World)");
            // Destroy preview object if ray doesn't hit anything in the world
            if (previewObject != null)
            {
                Destroy(previewObject);
                previewObject = null;
            }
        }
    }

    // Method to place the object at the hit point
    void PlaceObject(Vector3 placementPosition)
    {
        if (previewObject != null)
        {
            // Place the object at the hit location and destroy the preview
            Instantiate(objectToPlacePrefab, placementPosition, Quaternion.identity);
            Destroy(previewObject);
        }
    }
}
