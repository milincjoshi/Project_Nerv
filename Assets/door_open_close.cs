using UnityEngine;
using System.Collections;

public class door_open_close : MonoBehaviour {

	float DoorOpenAngle = -90f;
	float fadeSpeed = 1.5f;
	bool rotate = false;
	 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (rotate) 
		{
			Rotate_door();
		}
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") 
		{
			rotate = true;
		}
	}
	void OnTriggerExit(Collider other)
	{
		Close_door ();
		rotate = false;
	}
	void Rotate_door()
	{
		var target = Quaternion.Euler (0,DoorOpenAngle,0);
		transform.localRotation = Quaternion.Lerp (transform.localRotation, target, fadeSpeed * Time.deltaTime);
	}
	void Close_door()
	{
		var target = Quaternion.Euler (0,0,0);
		transform.localRotation = Quaternion.Lerp (transform.localRotation, target, fadeSpeed * Time.deltaTime);

	}
}
