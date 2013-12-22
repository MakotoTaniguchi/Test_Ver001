using UnityEngine;
using System.Collections;

public class RacketController : MonoBehaviour {

	private int Accel = 0;

	RacketController(){
		Accel = 1000;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody.AddForce (
			transform.right * Input.GetAxisRaw ("Horizontal") * Accel,
			ForceMode.Impulse);
	}
}
