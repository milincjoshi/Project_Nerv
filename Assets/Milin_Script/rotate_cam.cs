using UnityEngine;
using System.Collections;

public class rotate_cam : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		GameObject cam = GameObject.FindGameObjectWithTag ("MainCamera");
		GameObject target = GameObject.FindGameObjectWithTag ("Player"); 
		if (target != null )
		{
			transform.LookAt(target.transform);
			if (true)
			{
				//transform.Rotate(target.transform.position,Vector3.up, Time.deltaTime * 15);		
				//transform.Rotate(target.transform.position,  15);
				transform.RotateAround(target.transform.position, Vector3.up,Time.deltaTime * 15);
			}
			
		}
	}
}
