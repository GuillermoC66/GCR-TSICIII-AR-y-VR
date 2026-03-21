using UnityEngine;
using System.Collections.Generic;
using TMPro; 

public class RandomObjectToggler : MonoBehaviour
{

    public List<GameObject> objectsToToggle;

  
    private GameObject currentActiveObject;

    public void ToggleRandomObject()
    {

        if (currentActiveObject != null)
        {
            currentActiveObject.SetActive(false);
        }

        if (objectsToToggle.Count > 0)
        {
            int randomIndex = Random.Range(0, objectsToToggle.Count);
            GameObject randomObject = objectsToToggle[randomIndex];


            randomObject.SetActive(true);


            currentActiveObject = randomObject;
        }
    }
}