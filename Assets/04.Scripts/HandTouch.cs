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
            print("弧埃何利");
            
         
           
        }

        if (other.tag == "YELLOW")
        {
            print("畴鄂何利");

        }


        if (other.tag == "BLACK")
        {
            print("八篮何利");

        }


        if (other.tag == "BLUE")
        {
            print("颇尔何利");

        }


        if (other.tag == "WHITE")
        {
            print("窍踞何利");

        }





    }
}
    
    
