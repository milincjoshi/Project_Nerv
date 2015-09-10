using UnityEngine;
using System.Collections;

public class activate_lift : MonoBehaviour {


	//
	public bool open_door=false;
	public bool close_door=false;
	GameObject lift_doorLeft;
	GameObject lift_doorRight;
	GameObject lift;
	float smoothOpen = 0.4f;
	Vector3 left_oldPosition ;
	Vector3 left_newPosition ;

	Vector3 right_oldPosition ;
	Vector3 right_newPosition ;

	void Start () 
	{
			//
		lift = GameObject.FindGameObjectWithTag ("lift_panel");

		lift_doorLeft = GameObject.FindGameObjectWithTag ("lift_doorLeft");
		lift_doorRight = GameObject.FindGameObjectWithTag ("lift_doorRight");

		left_oldPosition = lift_doorLeft.transform.position;
		left_newPosition = new Vector3 (lift_doorLeft.transform.position.x + 0.25f, lift_doorLeft.transform.position.y,lift_doorLeft.transform.position.z);

		right_oldPosition = lift_doorRight.transform.position;
		right_newPosition = new Vector3 (lift_doorRight.transform.position.x - 0.25f, lift_doorRight.transform.position.y,lift_doorRight.transform.position.z);

	}
	
	void Update () 
	{
		if (open_door){	Open_liftDoors(); }
		if (close_door){ Close_liftDoors();	}
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.tag=="Player") 
		{
			AudioSource a = GetComponent<AudioSource>();
			a.Play();
			open_door = true;
			close_door = false;//open lift doors
		
		}

	}
	void OnTriggerLeave(Collider other)
	{
		if (other.tag=="Player") 
		{
			//deactivate lift panel
			close_door = true;
			open_door = false;//close lift doors
	
		}
	}
	void Open_liftDoors()
	{
		lift_doorLeft.transform.position = Vector3.Lerp (left_oldPosition,left_newPosition, smoothOpen * Time.time);
		lift_doorRight.transform.position = Vector3.Lerp (right_oldPosition,right_newPosition, smoothOpen * Time.time);

	}
	void Close_liftDoors()
	{
		lift_doorLeft.transform.position = Vector3.Lerp (left_newPosition,left_oldPosition, smoothOpen * Time.time);
		lift_doorRight.transform.position = Vector3.Lerp (right_newPosition,right_oldPosition, smoothOpen * Time.time);

	}

}
