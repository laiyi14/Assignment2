using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void onTriggerEnter(Collider other)
    {
        Debug.Log("Die!");
    }
}
