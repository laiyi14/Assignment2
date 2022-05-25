using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP : MonoBehaviour
{
    Transform location;
    PlayerMovement playerController;

    void Start()
    {
        playerController = gameObject.GetComponent<PlayerMovement>();
    }

    void Update()
    {
        // if(Input.GetMouseButtonDown(0))
        // {
        //     teleport();
        // }
    }
    IEnumerator TeleportationDelay()
    {
        playerController.disable = true;
        yield return new WaitForSeconds(0.01f);
        gameObject.transform.position = location.position;
        gameObject.transform.rotation = location.rotation;
        yield return new WaitForSeconds(0.01f);
        playerController.disable = false;
    }

    public void teleport(Transform pos)
    {
        location = pos;
        StartCoroutine("TeleportationDelay");
    }
}
