using UnityEngine;
using System.Collections;

public class anim_script : MonoBehaviour {

	public GameObject door;
	public Animator anim;
	// Use this for initialization
	void Start () {
		door = GameObject.FindGameObjectWithTag ("Door");

		anim = GetComponent<Animator>();


	}
	
	// Update is called once per frame
	void Update () {
		//door = GameObject.FindGameObjectWithTag ("Door");
		//Animation x = door.GetComponent<Animation>();
		//x.Play("Open_door");
		//GetComponent<Animation>().Play ("Open_door");

		anim.Play("Open_door");

	}
}
