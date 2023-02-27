using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallPlatform : MonoBehaviour
{
    Vector3 AliveAgain;
    public GameObject fallPlatform;

    // Start is called before the first frame update
    void Start()
    {
       
        AliveAgain = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "FallPlatform")
        {
            transform.position = AliveAgain;
        }
            
        
    }
}
