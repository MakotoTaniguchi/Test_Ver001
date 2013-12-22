using UnityEngine;
using System.Collections;

public class SphereStart : MonoBehaviour {

	private int speed = 0;

	SphereStart()
	{
		speed = 5;
	}

	// Use this for initialization
	void Start () {
		rigidbody.AddForce((transform.forward + transform.right) * speed
		                   , ForceMode.VelocityChange);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
