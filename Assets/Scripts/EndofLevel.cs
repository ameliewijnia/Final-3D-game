using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndofLevel : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) 
    {
        GameObject.Find("Player").SendMessage("Finish");
    }
}
