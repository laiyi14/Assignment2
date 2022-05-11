using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sun : MonoBehaviour {
//function: Day night circle 


	// Update is called once per frame
	void Update () {
		transform.RotateAround (Vector3.zero, Vector3.right, 11f * Time.deltaTime);//Rotate two light source. 
		//transform.LookAt (Vector3.zero);
	}
}
