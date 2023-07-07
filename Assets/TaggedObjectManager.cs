using System.Collections.Generic;
using UnityEngine;

public class TaggedObjectManager : MonoBehaviour
{
    public List<GameObject> pubObjects;
    public List<GameObject> restaurantObjects;
    public List<GameObject> landmarkObjects;
    public List<GameObject> entertainmentObjects;
    public List<GameObject> shoppingObjects;

    private void Start()
    {
        pubObjects = new List<GameObject>();
        restaurantObjects = new List<GameObject>();
        landmarkObjects = new List<GameObject>();
        entertainmentObjects = new List<GameObject>();
        shoppingObjects = new List<GameObject>();

        // Collect objects with specific tags into the lists
        CollectObjectsWithTag("Pub", pubObjects);
        CollectObjectsWithTag("Restaurant", restaurantObjects);
        CollectObjectsWithTag("Landmark", landmarkObjects);
        CollectObjectsWithTag("Entertainment", entertainmentObjects);
        CollectObjectsWithTag("Shopping", shoppingObjects);

        // Set all objects with specific tags to inactive
        SetObjectsInactive(pubObjects);
        SetObjectsInactive(restaurantObjects);
        SetObjectsInactive(landmarkObjects);
        SetObjectsInactive(entertainmentObjects);
        SetObjectsInactive(shoppingObjects);
    }

    private void CollectObjectsWithTag(string tag, List<GameObject> objectList)
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag(tag);
        foreach (GameObject obj in objects)
        {
            objectList.Add(obj);
        }
    }

    private void SetObjectsInactive(List<GameObject> objects)
    {
        foreach (GameObject obj in objects)
        {
            obj.SetActive(false);
        }
    }

    public void TogglePubObjects()
    {
        ToggleObjects(pubObjects);
    }

    public void ToggleRestaurantObjects()
    {
        ToggleObjects(restaurantObjects);
    }

    public void ToggleLandmarkObjects()
    {
        ToggleObjects(landmarkObjects);
    }

    public void ToggleEntertainmentObjects()
    {
        ToggleObjects(entertainmentObjects);
    }

    public void ToggleShoppingObjects()
    {
        ToggleObjects(shoppingObjects);
    }

    private void ToggleObjects(List<GameObject> objects)
    {
        foreach (GameObject obj in objects)
        {
            obj.SetActive(!obj.activeSelf);
        }
    }
}
