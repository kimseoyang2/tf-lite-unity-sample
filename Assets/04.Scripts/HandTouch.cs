using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandTouch : MonoBehaviour


{

    public HandTrackingSample handTrackingSample;
    public GameObject RedFlag;
    public GameObject YellowFlag;
    public GameObject BlueFlag;
    public GameObject BlackFlag;
    public GameObject WhiteFlag;

    public GameObject TargetObject;
    public GameObject OrientObject;


    public bool isON;
    public bool isBLUE;
    public bool isBLACK;
    public bool isWHITE;
    public bool isYELLOW;

    public string previous;

    public int i=0;

    public Vector3 RedPos;
    public Vector3 YellowPos;
    public Vector3 BluePos;
    public Vector3 BlackPos;
    public Vector3 WhitePos;
    public Vector3 OrientPos;

    public bool isSelect=false;

    public string Result;

    public GameObject BLACK;
    public GameObject BLUE;
    public GameObject RED;
    public GameObject WHITE;
    public GameObject YELLOW;

    public GameObject Flags;
     public GameObject UI1;
    public GameObject UI2;

    // Start is called before the first frame update
    void Start()
    {
        RedPos = RedFlag.transform.position;
        YellowPos = YellowFlag.transform.position;
        BluePos = BlueFlag.transform.position;
        BlackPos = BlackFlag.transform.position;
        WhitePos = WhiteFlag.transform.position;

        OrientPos= OrientObject.transform.position;

        


        Invoke("delay", 5f);
        





    }

    void delay()
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = true;
    }

    private void Update()
    {
        

        if (TargetObject.name.Contains(previous))
        {
            TargetObject.transform.position = new Vector3(handTrackingSample.cusorBox.transform.position.x, handTrackingSample.cusorBox.transform.position.y, handTrackingSample.cusorBox.transform.position.z);
        }

        if (isSelect)
        {

            Flags.SetActive(false);
            UI1.SetActive(false);
            UI2.SetActive(true);

            if (Result=="RED")
            {
                RED.SetActive(true);
            }

            if (Result == "BLUE")
            {
                BLUE.SetActive(true);
            }

            if (Result == "BLACK")
            {
                BLACK.SetActive(true);
            }

            if (Result == "WHITE")
            {
                WHITE.SetActive(true);
            }
            if (Result == "YELLOW")
            {
                YELLOW.SetActive(true);
            }
            

        }

   
        
    }


    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {

        

      
            if (previous!="RED" && other.tag == "RED")
            {
                

                 TargetObject = RedFlag;
            
                 print("RED");
                 previous = "RED";
                YellowFlag.transform.position = YellowPos;
                BlueFlag.transform.position = BluePos;
                 BlackFlag.transform.position = BlackPos;
             WhiteFlag.transform.position = WhitePos;


        }
      

        

            if (previous != "YELLOW" && other.tag == "YELLOW")
            {
                TargetObject = YellowFlag;
                print("YELLOW");
                previous = "YELLOW";
                RedFlag.transform.position = RedPos;
                BlueFlag.transform.position = BluePos;
                BlackFlag.transform.position = BlackPos;
                WhiteFlag.transform.position = WhitePos;



        }




        if (previous != "BLACK" && other.tag == "BLACK")
            {
                TargetObject = BlackFlag;
                print("BLACK");
                previous = "BLACK";
                RedFlag.transform.position = RedPos;
                YellowFlag.transform.position = YellowPos;
                BlueFlag.transform.position = BluePos;
                WhiteFlag.transform.position = WhitePos;


        }
      


       

            if (previous != "BLUE" && other.tag == "BLUE")
            {
                TargetObject = BlueFlag;
                print("BLUE");
                previous = "BLUE";
                RedFlag.transform.position = RedPos;
                YellowFlag.transform.position = YellowPos;
                BlackFlag.transform.position = BlackPos;
                WhiteFlag.transform.position = WhitePos;



        }




        if (previous != "WHITE" && other.tag == "WHITE")
            {
                TargetObject = WhiteFlag;
                print("WHITE");
                previous = "WHITE";
                RedFlag.transform.position = RedPos;
                YellowFlag.transform.position = YellowPos;
                BlueFlag.transform.position = BluePos;
                BlackFlag.transform.position = BlackPos;


        }

        if (isSelect==false && other.tag == "select")
        {
            TargetObject.transform.position = OrientPos;
            print("º±≈√");
            Result= previous;
            isSelect = true;

        }





    }
}
    
    
