using UnityEngine;
using System.Collections;
using System;

public class day_night : MonoBehaviour {
	
	private bool setInitialRotation = true;
	public GameObject target;
	private Light sun;
	DateTime dt; 
	float currentDegree;

	void Start()
	{
		dt  = DateTime.Now;
		currentDegree = (dt.Hour * 360) / 24;
	
		sun = GameObject.FindGameObjectWithTag("Sun").GetComponent<Light>();
	}

	void Update()
	{
		ManageShadows ();
		ManageRotationofSun ();
	}

	void ManageRotationofSun()
	{
		if (setInitialRotation)//wait and run initial rotation 
		{
			transform.RotateAround(target.transform.position,Vector3.forward, currentDegree );
			setInitialRotation = false;
		}
		else//set flag 1
		{
			transform.LookAt (target.transform);
			transform.RotateAround (target.transform.position, Vector3.forward, (float)0.004166 * Time.deltaTime);
			//transform.RotateAround (target.transform.position, Vector3.forward, 15 * Time.deltaTime);
		}
	}

	void ManageShadows()
	{
		if (dt.Hour>=6 && dt.Hour < 9) {
			sun.shadows = LightShadows.Soft;
		}
		else if (dt.Hour>= 9 && dt.Hour<17) 
		{
			sun.shadows = LightShadows.Hard;	
		}
		else 
		{
			sun.shadows = LightShadows.None;
		}
	}

}
