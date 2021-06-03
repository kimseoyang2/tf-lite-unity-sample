using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterManager : MonoBehaviour
{
    public GameObject InputEnd;
    public GameObject Scene01;
    public GameObject Scene02;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (InputEnd)
        {
            if (InputEnd.GetComponent<TW_MultiStrings_RandomPointer>().isEnd == true)
            {
                Invoke("DelayTime", 2f);
                
                Scene02.SetActive(true);
            }
        }
    }

    public void DelayTime()
    {
        Scene01.SetActive(false);
    }

    public void OFF_Title()
    {
        

    }
}
