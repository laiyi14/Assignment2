using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public TP TPController;
    Transform Location;
    public GameObject player;

    void start()
    {
        TPController = player.GetComponent<TP>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Platform")
        {
            Location = collision.gameObject.GetComponent<Platform>().TpPos;
            Destroy(this.gameObject);
            TPController.teleport(Location);
        }
    }
}
