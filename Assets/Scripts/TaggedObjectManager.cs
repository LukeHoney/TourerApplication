using System.Collections.Generic;
using UnityEngine;

public class TaggedObjectManager : MonoBehaviour
{
    public List<GameObject> pubObjects;
    public List<GameObject> restaurantObjects;
    public List<GameObject> landmarkObjects;
    public List<GameObject> entertainmentObjects;
    public List<GameObject> shoppingObjects;

    public int distanceFromPlayer;

    private GameObject player;

    private bool isPubObjectsActive = false;
    private bool isRestaurantObjectsActive = false;
    private bool isLandmarkObjectsActive = false;
    private bool isEntertainmentObjectsActive = false;
    private bool isShoppingObjectsActive = false;

    private void Start()
    {
        player = GameObject.Find("Player");

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
    }

    private void CollectObjectsWithTag(string tag, List<GameObject> objectList)
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag(tag);
        foreach (GameObject obj in objects)
        {
            objectList.Add(obj);
        }
    }

    private void Update()
    {
        if (isPubObjectsActive)
        {
            CheckActivation(pubObjects);
        }
        else
        {
            SetObjectsInactive(pubObjects);
        }

        if (isRestaurantObjectsActive)
        {
            CheckActivation(restaurantObjects);
        }
        else
        {
            SetObjectsInactive(restaurantObjects);
        }

        if (isLandmarkObjectsActive)
        {
            CheckActivation(landmarkObjects);
        }
        else
        {
            SetObjectsInactive(landmarkObjects);
        }

        if (isEntertainmentObjectsActive)
        {
            CheckActivation(entertainmentObjects);
        }
        else
        {
            SetObjectsInactive(entertainmentObjects);
        }

        if (isShoppingObjectsActive)
        {
            CheckActivation(shoppingObjects);
        }
        else
        {
            SetObjectsInactive(shoppingObjects);
        }
    }

    private void CheckActivation(List<GameObject> objects)
    {
        foreach (GameObject obj in objects)
        {
            if (Vector3.Distance(player.transform.position, obj.transform.position) > distanceFromPlayer)
            {
                obj.SetActive(false);
            }
            else
            {
                obj.SetActive(true);
            }
        }
    }

    public void SetPubObjectsActive()
    {
        isPubObjectsActive = true;
    }

    public void SetPubObjectsInactive()
    {
        isPubObjectsActive = false;
    }

    public void SetRestaurantObjectsActive()
    {
        isRestaurantObjectsActive = true;
    }

    public void SetRestaurantObjectsInactive()
    {
        isRestaurantObjectsActive = false;
    }

    public void SetLandmarkObjectsActive()
    {
        isLandmarkObjectsActive = true;
    }

    public void SetLandmarkObjectsInactive()
    {
        isLandmarkObjectsActive = false;
    }

    public void SetEntertainmentObjectsActive()
    {
        isEntertainmentObjectsActive = true;
    }

    public void SetEntertainmentObjectsInactive()
    {
        isEntertainmentObjectsActive = false;
    }

    public void SetShoppingObjectsActive()
    {
        isShoppingObjectsActive = true;
    }

    public void SetShoppingObjectsInactive()
    {
        isShoppingObjectsActive = false;
    }

    private void SetObjectsInactive(List<GameObject> objects)
    {
        foreach (GameObject obj in objects)
        {
            obj.SetActive(false);
        }
    }
}
