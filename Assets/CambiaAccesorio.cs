using UnityEngine;
using System.Collections.Generic; // Required for using Lists
using TMPro; // Required if using TextMeshPro for the button

public class RandomObjectToggler : MonoBehaviour
{
    // A list to hold all the GameObjects you want to toggle
    public List<GameObject> objectsToToggle;

    // A reference to the currently active random object (optional, for management)
    private GameObject currentActiveObject;

    public void ToggleRandomObject()
    {
        // 1. Deactivate the previously active object, if any
        if (currentActiveObject != null)
        {
            currentActiveObject.SetActive(false);
        }

        // 2. Select a new random object from the list
        if (objectsToToggle.Count > 0)
        {
            int randomIndex = Random.Range(0, objectsToToggle.Count);
            GameObject randomObject = objectsToToggle[randomIndex];

            // 3. Toggle the active state of the new random object
            // Use !randomObject.activeSelf to set the opposite of its current state
            // However, since we just deactivated the previous one, the new one should be set to true
            randomObject.SetActive(true);

            // 4. Update the reference to the current active object
            currentActiveObject = randomObject;
        }
    }
}