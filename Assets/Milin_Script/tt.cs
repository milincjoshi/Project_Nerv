using UnityEngine;
using System.Collections;

public class tt : MonoBehaviour {

	float y;
	float speed = 2f;

	void Start () {
		
		y = transform.position.y;
	}
	

	void Update () {
		
		
	}
	void OnTriggerEnter()
	{
		Debug.Log ("Working");
		lift1();
	}
	
	void lift1()
	{
		y = y + 20;
		Vector3 v =new Vector3(transform.position.x,y,transform.position.z);
		//transform.position = v * Time.deltaTime;
		GameObject lit = GameObject.FindGameObjectWithTag ("lift"); 
		transform.position = Vector3.MoveTowards(transform.position, v, Time.deltaTime * speed);
	}
}
