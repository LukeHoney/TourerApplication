using System.Collections;
using System.Collections.Generic;
using Google.XR.ARCoreExtensions.Samples.Geospatial;
using UnityEngine;

public class ARStartScript : MonoBehaviour
{
    public GeospatialController geospatialControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        geospatialControllerScript.OnGetStartedClicked();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
