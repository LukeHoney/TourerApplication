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

        CollectObjectsWithTag("Pub", pubObjects);
        CollectObjectsWithTag("Restaurant", restaurantObjects);
        CollectObjectsWithTag("Landmark", landmarkObjects);
        CollectObjectsWithTag("Entertainment", entertainmentObjects);
        CollectObjectsWithTag("Shopping", shoppingObjects);

        SetObjectsActiveState(pubObjects, false);
        SetObjectsActiveState(restaurantObjects, false);
        SetObjectsActiveState(landmarkObjects, false);
        SetObjectsActiveState(entertainmentObjects, false);
        SetObjectsActiveState(shoppingObjects, false);
    }

    private void CollectObjectsWithTag(string tag, List<GameObject> objectList)
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag(tag);
        foreach (GameObject obj in objects)
        {
            objectList.Add(obj);
        }
    }

    private void SetObjectsActiveState(List<GameObject> objects, bool isActive)
    {
        foreach (GameObject obj in objects)
        {
            obj.SetActive(isActive);
        }
    }

    public void SetObjectsActive(List<GameObject> objects)
    {
        SetObjectsActiveState(objects, true);
    }

    public void SetObjectsInactive(List<GameObject> objects)
    {
        SetObjectsActiveState(objects, false);
    }

    public void SetPubObjectsActive()
    {
        SetObjectsActive(pubObjects);
    }

    public void SetPubObjectsInactive()
    {
        SetObjectsInactive(pubObjects);
    }

    public void SetRestaurantObjectsActive()
    {
        SetObjectsActive(restaurantObjects);
    }

    public void SetRestaurantObjectsInactive()
    {
        SetObjectsInactive(restaurantObjects);
    }

    public void SetLandmarkObjectsActive()
    {
        SetObjectsActive(landmarkObjects);
    }

    public void SetLandmarkObjectsInactive()
    {
        SetObjectsInactive(landmarkObjects);
    }

    public void SetEntertainmentObjectsActive()
    {
        SetObjectsActive(entertainmentObjects);
    }

    public void SetEntertainmentObjectsInactive()
    {
        SetObjectsInactive(entertainmentObjects);
    }

    public void SetShoppingObjectsActive()
    {
        SetObjectsActive(shoppingObjects);
    }

    public void SetShoppingObjectsInactive()
    {
        SetObjectsInactive(shoppingObjects);
    }
}
