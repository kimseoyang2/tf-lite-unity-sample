using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene00 : MonoBehaviour
{

  
    public int SceneNum;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    public void NEXTScene()
    {
        SceneManager.LoadScene(SceneNum);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
