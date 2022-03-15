using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public BBall bball;
    public GameObject playerCamera;

    public float ballDistance = 2.25f;
    public float shootForce = 400f;

    public bool holdingBall = true;

    // Start is called before the first frame update
    void Start()
    {
        bball.GetComponent<Rigidbody>().useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (holdingBall)
        {
            bball.transform.position = playerCamera.transform.position + playerCamera.transform.forward * ballDistance;

            if (Input.GetMouseButtonDown(0))
            {
                holdingBall = false;
                bball.ActivateTrail();
                bball.GetComponent<Rigidbody>().useGravity = true;
                bball.GetComponent<Rigidbody>().AddForce(playerCamera.transform.forward * shootForce);
            }
        }

        
    }
}
