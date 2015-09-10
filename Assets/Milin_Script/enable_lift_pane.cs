using UnityEngine;
using System.Collections;

public class enable_lift_pane : MonoBehaviour {

	GameObject lift_panel;
	bool isVisible = false;

	void Start()
	{
		lift_panel = GameObject.FindGameObjectWithTag ("lift_panel");
	}
	void Update()
	{
		if (isVisible) 
		{
			lift_panel.SetActive (true);
		}
		else 
		{
			lift_panel.SetActive(false);
		}
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") 
		{
			isVisible = true;	
		}
	}
	void OnTriggerExit(Collider other)
	{
		if (other.tag == "Player") 
		{
			isVisible=false;
		}

	}

}
