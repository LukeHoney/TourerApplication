using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform target; //refernce to what chicken has to look at target
    
    void Update()
    {
        transform.LookAt(target); //code to make object look at the target
        
    }
}
