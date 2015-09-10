using UnityEngine;
using System.Collections;

public class Button_functions : MonoBehaviour {

	
	public void disable_canvas()
	{
		GameObject.FindGameObjectWithTag ("intro_panel").SetActive(false);

	}
	public void dr_andrei_navigate()
	{
		GameObject navLine = GameObject.FindGameObjectWithTag ("navLine");
		GameObject Player = GameObject.FindGameObjectWithTag ("Player");
		
		navLine.transform.position = Player.transform.position + new Vector3 (0f,0,0f);;

		//navLine.transform.position = GameObject.FindGameObjectWithTag ("DeptOffice").transform.position;
		//GameObject.FindGameObjectWithTag("navLine").GetComponent<Simple_agent>().target.position = GameObject.FindGameObjectWithTag ("DeptOffice").transform.position;

		//GameObject.FindGameObjectWithTag("navLine").GetComponent<Simple_agent>().target.position = GameObject.FindGameObjectWithTag ("DeptOffice").transform.position;

		NavMeshAgent nav = navLine.GetComponent<NavMeshAgent>();
		nav.enabled = true;
		
		(navLine.GetComponent( "Simple_agent" ) as MonoBehaviour).enabled = true;
	}

	public void go_to_floor1()
	{
		Debug.Log ("Floor1");
	}
	public void go_to_floor2()
	{
		Debug.Log ("Floor2");
	}
	public void go_to_floor5()
	{
		Debug.Log ("Floor5");
	}
	public void go_to_floor6()
	{
		Debug.Log ("Floor6");
	}
	public void go_to_floor8()
	{
		Debug.Log ("Floor8");
	}
}
