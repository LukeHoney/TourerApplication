using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    
    [SerializeField] float movementSpeed = 6f;
    [SerializeField] float jumpForce = 5f;
    

    // Start is called before the first frame update
    void Start()
    {

    }
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("up"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 5);
        }
        if (Input.GetButtonDown("down"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -5);
        }
        if (Input.GetButtonDown("right"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(5, 0, 0);
        }
        if (Input.GetButtonDown("left"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(-5, 0, 0);
        }
    }

    

    

    
}
