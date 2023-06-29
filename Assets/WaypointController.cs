using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointController : MonoBehaviour
{
    public List<Transform> waypoints;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public Transform GetNextWaypoint(Transform currentWaypoint)
    {
       if(currentWaypoint == null)
       {
            return transform.GetChild(0);
       }

        return null;
    }
}
