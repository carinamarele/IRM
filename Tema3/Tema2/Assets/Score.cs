using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public GameObject effectObject;

    private void Start()
    {
        effectObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.transform.gameObject.GetComponent<ThrowBallBehaviour>() != null)
        {
            Debug.Log("IRM");
            effectObject.SetActive(true);
        }
    }
}
