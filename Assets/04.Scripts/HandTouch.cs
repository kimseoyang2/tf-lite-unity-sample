using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandTouch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "RED")
        {
            print("RED");
            
         
           
        }

        if (other.tag == "YELLOW")
        {
            print("YELLOW");

        }


        if (other.tag == "BLACK")
        {
            print("BLACK");

        }


        if (other.tag == "BLUE")
        {
            print("BLUE");

        }


        if (other.tag == "WHITE")
        {
            print("WHITE");

        }





    }
}
    
    
