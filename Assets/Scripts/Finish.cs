using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{

    //private float startTime;
    //float fastTime = 0:30.30;
    //float gameFinish = 0:50.20;


    float timer = 0.0f;

    // Start is called before the first frame update
    private void Start()
    {
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.name == "Player") {
            if (timer < 30.0f) {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            } else {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
           }
        }  
    }

   private void Update()
   {
    timer += Time.deltaTime;
   }

}
