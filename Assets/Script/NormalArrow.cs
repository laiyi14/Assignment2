using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalArrow : MonoBehaviour
{
    public float speed = 100;

    public float lifeTime = 3.0f;

    void Start () 
    {
        Destroy(this.gameObject, lifeTime);
    }

	void Update () 
    {
        Movement();
    }

    public virtual void Movement() 
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    public virtual void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Environment") 
        {
            Destroy(this.gameObject);
        }
    }
}
