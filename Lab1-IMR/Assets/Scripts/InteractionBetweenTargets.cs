using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionBetweenTargets : MonoBehaviour
{
    public GameObject obiect1;
    public GameObject obiect2;
    public GameObject cat;
    public GameObject Fox;
    Animator anim1;
    // Start is called before the first frame update
    void Start()
    {
        anim1=Fox.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance=Vector3.Distance(obiect1.transform.position,obiect2.transform.position);

        if(distance<1) { 
               

        }
     Debug.Log(distance);
    }
}
