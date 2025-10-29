 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariabllesAndFunctions : MonoBehaviour
{
    //create my integer variable
    int myInt = 5;


    // Start is called before the first frame update
    void Start()
    {
        //run  my variable through my function 
        myInt = MultiplyByTwo(myInt);
        Debug.Log(myInt);
    }

    // Update is called once per frame
    void Update()
    {

    }

    //create the multiply by two function
    int MultiplyByTwo(int number)
    {
        //create local variable 
        int result;

        //multiply the num,ber  by two
        result = number * 2;

        //return the value
        return result;
    }

}
