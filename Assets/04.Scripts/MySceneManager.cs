using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace Michsky.UI.ModernUIPack
{
    public class MySceneManager : MonoBehaviour
    {
        public float Percent;
        public ProgressBar progressBar;
        public bool IsTD=false;
        public bool IsStarted = false;
        // Start is called before the first frame update
        void Start()
        {
            progressBar = this.gameObject.GetComponent<ProgressBar>();
        }

        // Update is called once per frame
        void Update()
        {
            Percent = progressBar.currentPercent;
            
            if (IsStarted==false&&Percent>100f)
            {
                IsTD = true;

                if (IsTD)
                {
                    StartCoroutine(To_The_TD_Scene());
                    IsStarted = true;


                }

             

            }

           

            
        }

        IEnumerator To_The_TD_Scene()
        {
            IsTD = false;
            float seconds = 2f;
            yield return new WaitForSeconds(seconds);
           
            print(seconds);
            SceneManager.LoadScene(1);
        }
    }

}