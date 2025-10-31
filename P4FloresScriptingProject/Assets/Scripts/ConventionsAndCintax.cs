using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConventionsAndCintax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //this  line is there to tell me the x position of my object
        Debug.Log(transform.position.x);


    }

    // Update is called once per frame
    void Update()

        if (Transform.position.y <=  5f)
    {
        Debug.Log("I'm about to hit the ground!");
    }
}