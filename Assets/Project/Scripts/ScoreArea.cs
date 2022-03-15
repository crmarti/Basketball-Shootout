using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreArea : MonoBehaviour
{
    public GameObject effectObject;

    void Start()
    {
        effectObject.SetActive(false);
    }
    
    void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.GetComponent<BBall>() != null)
        {
            effectObject.SetActive(true);
        }

    }
}
