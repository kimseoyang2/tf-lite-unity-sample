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
            print("��������");
            
         
           
        }

        if (other.tag == "YELLOW")
        {
            print("�������");

        }


        if (other.tag == "BLACK")
        {
            print("��������");

        }


        if (other.tag == "BLUE")
        {
            print("�Ķ�����");

        }


        if (other.tag == "WHITE")
        {
            print("�Ͼ����");

        }





    }
}
    
    
