using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{

    public float count;
    public int SceneNum;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("NEXTScene", count);
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
