using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NewBehaviourScript : MonoBehaviour
{
  
    public GameObject card;
    public GameObject carnet;
    public GameObject cactus1;
    public GameObject cactus2;

    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("isClose", false);
    }

    // Update is called once per frame
    void Update()
    {
        if ( verify())
        {
            anim.SetBool("isClose", true);
        }
        else
        {
            anim.SetBool("isClose", false);

        }


    }
    bool verify()
    {
        float distance;
        distance = Vector3.Distance(cactus1.transform.position, cactus2.transform.position);
        if( distance < 10)
                return true;
        return false;
    }

}
