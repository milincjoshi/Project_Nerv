using UnityEngine;
using System.Collections;

public class button_test : MonoBehaviour {

	float y;
	float speed = 0.01f;
	bool setLiftinMotion = false;

	private float liftSpeed = 0.1f;

	private Vector3 deptHead = new Vector3(12.45f,1.20f,9.76f);
	private Vector3 Library = new Vector3(-24f,0.1f,39.87f);
	private Vector3 health_center = new Vector3(-64.79f,0.1f,39.5f);

	private GameObject lift;
	private Vector3 floor1;
	private Vector3 floor2;
	private Vector3 floor5;
	private Vector3 floor6;
	private Vector3 floor7;
	private Vector3 floor8;
	GameObject player,navLine;

	void Awake()
	{
		navLine = GameObject.FindGameObjectWithTag ("navLine");
		player = GameObject.FindGameObjectWithTag ("Player");
		navLine.transform.position = player.transform.position;

	}
	void Start()
	{
		navLine = GameObject.FindGameObjectWithTag ("navLine");
		player = GameObject.FindGameObjectWithTag ("Player");
		navLine.transform.position = player.transform.position;

		y = transform.position.y;

		lift = GameObject.FindGameObjectWithTag ("lift");

		floor1 = new Vector3 (lift.transform.position.x, 0.5f, lift.transform.position.z);
		floor2 = new Vector3 (lift.transform.position.x, 1.52f, lift.transform.position.z);
		floor5 = new Vector3 (lift.transform.position.x, 2.5f, lift.transform.position.z);
		floor6 = new Vector3 (lift.transform.position.x, 3.46f, lift.transform.position.z);
		floor7 = new Vector3 (lift.transform.position.x, 4.46f, lift.transform.position.z);
		floor8 = new Vector3 (lift.transform.position.x, 6.5f, lift.transform.position.z);

	}
	public void disable_canvas()
	{
		lift = GameObject.FindGameObjectWithTag ("lift");
	
		GameObject c = GameObject.FindGameObjectWithTag ("intro_panel");
		c.SetActive (false);
	}
	public void dr_andrei_navigate()
	{
		navLine.transform.position = player.transform.position;
		navLine.GetComponent<Simple_agent> ().target.position = deptHead;
		NavMeshAgent nav = navLine.GetComponent<NavMeshAgent>();
		nav.enabled = true;
		(navLine.GetComponent( "Simple_agent" ) as MonoBehaviour).enabled = true;
	}
	public void Library_navigate()
	{
		navLine.GetComponent<Simple_agent> ().target.position = Library;
		NavMeshAgent nav = navLine.GetComponent<NavMeshAgent>();
		nav.enabled = true;
		(navLine.GetComponent( "Simple_agent" ) as MonoBehaviour).enabled = true;
		
	}
	public void Student_HC_navigate()
	{
		navLine.GetComponent<Simple_agent> ().target.position = health_center;
		NavMeshAgent nav = navLine.GetComponent<NavMeshAgent>();
		nav.enabled = true;
		(navLine.GetComponent( "Simple_agent" ) as MonoBehaviour).enabled = true;
		
	}

	public void go_to_floor1()
	{
		Debug.Log ("Floor1");
		GameObject leftDoor = GameObject.FindGameObjectWithTag ("lift_doorLeft");
		GameObject rightDoor = GameObject.FindGameObjectWithTag ("lift_doorRight");
		while (lift.transform.position != floor1) {
			lift.transform.position = Vector3.MoveTowards (lift.transform.position, floor1, Time.deltaTime * speed);	
			player.transform.position = Vector3.MoveTowards (player.transform.position, new Vector3(player.transform.position.x,floor1.y,player.transform.position.z), Time.deltaTime * speed);	
		}

	}
	public void go_to_floor2()
	{
		Debug.Log ("Floor2");
		GameObject leftDoor = GameObject.FindGameObjectWithTag ("lift_doorLeft");
		GameObject rightDoor = GameObject.FindGameObjectWithTag ("lift_doorRight");
		while (lift.transform.position != floor2) {
			lift.transform.position = Vector3.MoveTowards (lift.transform.position, floor2, Time.deltaTime * speed);	
			player.transform.position = Vector3.MoveTowards (player.transform.position, new Vector3(player.transform.position.x,floor2.y,player.transform.position.z), Time.deltaTime * speed);	

//			leftDoor.transform.position = Vector3.MoveTowards (leftDoor.transform.position, floor2, Time.deltaTime * speed);	
//			rightDoor.transform.position = Vector3.MoveTowards (rightDoor.transform.position, floor2, Time.deltaTime * speed);	
		}
	}
	public void go_to_floor5()
	{
		Debug.Log ("Floor5");
		GameObject leftDoor = GameObject.FindGameObjectWithTag ("lift_doorLeft");
		GameObject rightDoor = GameObject.FindGameObjectWithTag ("lift_doorRight");
		while (lift.transform.position != floor5) {
			lift.transform.position = Vector3.MoveTowards (lift.transform.position, floor5, Time.deltaTime * speed);	
			player.transform.position = Vector3.MoveTowards (player.transform.position, new Vector3(player.transform.position.x,floor5.y,player.transform.position.z), Time.deltaTime * speed);	

//			leftDoor.transform.position = Vector3.MoveTowards (leftDoor.transform.position, floor5, Time.deltaTime * speed);	
//			rightDoor.transform.position = Vector3.MoveTowards (rightDoor.transform.position, floor5, Time.deltaTime * speed);	
			
		}
	}
	public void go_to_floor6()
	{
		Debug.Log ("Floor6");
		GameObject leftDoor = GameObject.FindGameObjectWithTag ("lift_doorLeft");
		GameObject rightDoor = GameObject.FindGameObjectWithTag ("lift_doorRight");
		while (lift.transform.position != floor6) {
			lift.transform.position = Vector3.MoveTowards (lift.transform.position, floor6, Time.deltaTime * speed);	
			player.transform.position = Vector3.MoveTowards (player.transform.position, new Vector3(player.transform.position.x,floor6.y,player.transform.position.z), Time.deltaTime * speed);	

//			leftDoor.transform.position = Vector3.MoveTowards (leftDoor.transform.position, floor6, Time.deltaTime * speed);	
//			rightDoor.transform.position = Vector3.MoveTowards (rightDoor.transform.position, floor6, Time.deltaTime * speed);	
		}
	}
	public void go_to_floor7()
	{
		Debug.Log ("Floor7");
		GameObject leftDoor = GameObject.FindGameObjectWithTag ("lift_doorLeft");
		GameObject rightDoor = GameObject.FindGameObjectWithTag ("lift_doorRight");
		while (lift.transform.position != floor7) {
			lift.transform.position = Vector3.MoveTowards (lift.transform.position, floor7, Time.deltaTime * speed);	
			player.transform.position = Vector3.MoveTowards (player.transform.position, new Vector3(player.transform.position.x,floor7.y,player.transform.position.z), Time.deltaTime * speed);	
//			leftDoor.transform.position = Vector3.MoveTowards (leftDoor.transform.position, floor7, Time.deltaTime * speed);	
//			rightDoor.transform.position = Vector3.MoveTowards (rightDoor.transform.position, floor7, Time.deltaTime * speed);	
		}
	}
	public void go_to_floor8()
	{
		Debug.Log ("Floor8");
		GameObject leftDoor = GameObject.FindGameObjectWithTag ("lift_doorLeft");
		GameObject rightDoor = GameObject.FindGameObjectWithTag ("lift_doorRight");
		while (lift.transform.position != floor8) {
			lift.transform.position = Vector3.MoveTowards (lift.transform.position, floor8, Time.deltaTime * speed);	
			player.transform.position = Vector3.MoveTowards (player.transform.position, new Vector3(player.transform.position.x,floor8.y,player.transform.position.z), Time.deltaTime * speed);	
//			leftDoor.transform.position = Vector3.MoveTowards (leftDoor.transform.position, floor8,  speed);	
//			rightDoor.transform.position = Vector3.MoveTowards (rightDoor.transform.position, floor8,speed);	
		}
	}
}
