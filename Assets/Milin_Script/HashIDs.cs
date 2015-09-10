using UnityEngine;
using System.Collections;

public class HashIDs : MonoBehaviour {


	public int locomotionState;
	public int speedFloat;

	void Awake(){

		locomotionState = Animator.StringToHash ("Base Layer.Locomotion");
		speedFloat = Animator.StringToHash("Speed");
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
