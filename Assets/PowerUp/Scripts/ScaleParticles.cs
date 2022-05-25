using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class ScaleParticles : MonoBehaviour {
	void Update () {
		var gmain = GetComponent<ParticleSystem>().main;
		gmain.startSize = transform.lossyScale.magnitude;
	}
}