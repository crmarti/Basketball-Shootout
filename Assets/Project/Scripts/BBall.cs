using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BBall : MonoBehaviour
{
    public GameObject trailObject;

    // Start is called before the first frame update
    void Start()
    {
        trailObject.SetActive(false);
    }

    public void ActivateTrail()
    {
        trailObject.SetActive(true);
    }
}
