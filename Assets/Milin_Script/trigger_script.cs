using UnityEngine;
using System.Collections;

public class trigger_script : MonoBehaviour {

	float y;
	float speed = 1f;
	bool setLiftinMotion = false;
	GameObject lit;

	void Start () 
	{
		y = transform.position.y;
		lit =  GameObject.FindGameObjectWithTag ("lift"); 
	}

	void Update () 
	{
		if (setLiftinMotion == false) 
		{

		}
		else 
		{

		}
		
	}

	void OnTriggerStay(Collider other)
	{
		if (other.tag=="Player")
		{
			setLiftinMotion = true;
			y = y + 20;
			Vector3 v =new Vector3(transform.position.x,y,transform.position.z);
			lit.transform.position = Vector3.MoveTowards(lit.transform.position, v, Time.deltaTime * speed);	

		}
	}

}
