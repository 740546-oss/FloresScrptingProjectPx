using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player 

{
    //<Member variables can be reffered to as fields>
    private int experience;

    //Experience is a basic property
    public int Experience
    {
        get
        {
            //Some other code
            return experience; 
        }
        set 
        {
            //Some other code
            experience = value;
        }
    }
    //Level is a property that converts experience to leve of a player automattically
    public int Level
    {
        get
        {
            return experience / 1000;
        }
    }

    //This is an example of an auto-implemented property.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
