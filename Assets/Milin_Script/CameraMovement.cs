using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	private Vector3 offset;
	public float turnSpeed = 4.0f;
	public float smooth = 1.5f;

	void Start () {
	
		offset = new Vector3(0f, 0.5f, -1f);
		GameObject player = GameObject.FindGameObjectWithTag ("Player");
		transform.position = player.transform.position + offset;
	
	
	}
	
	void LateUpdate () {
	
		GameObject player = GameObject.FindGameObjectWithTag ("Player");
		transform.position = player.transform.position + offset;

	}


//	public float smooth = 1.5f;
//	private Transform player;
//	private Vector3 relCameraPos;
//	private float relCameraPosMag;
//	private Vector3 newPos;
//
//	void Awake()
//	{
//		player = GameObject.FindGameObjectWithTag (Tags.player).transform;
//		relCameraPos = transform.position - player.position;
//		relCameraPosMag = relCameraPos.magnitude - 0.5f;
//
//	}
//	void FixedUpdate()
//	{
//		Vector3 StandardPos = player.position + relCameraPos;
//		Vector3 abovePos = player.position + Vector3.up * relCameraPosMag;
//		Vector3[] checkPoints = new Vector3[5];
//		checkPoints [0] = StandardPos;
//		checkPoints [1] = Vector3.Lerp (StandardPos,abovePos,0.25f);
//		checkPoints [2] = Vector3.Lerp (StandardPos,abovePos,0.5f);
//		checkPoints [3] = Vector3.Lerp (StandardPos,abovePos,0.75f);
//		checkPoints [4] = abovePos;
//
//		for (int i = 0; i < checkPoints.Length; i++)
//		{
//			if (ViewingPosCheck(checkPoints[i]))
//			{
//				break;
//			}
//		}
//
//		transform.position = Vector3.Lerp (transform.position,newPos,smooth * Time.deltaTime);
//		SmoothLookAt ();
//	}
//
//	bool ViewingPosCheck( Vector3 checkPos)
//	{
//		RaycastHit hit;
//		if (Physics.Raycast(checkPos,player.position-checkPos,out hit, relCameraPosMag))
//		{
//			if (hit.transform != player)
//			{
//				return false;
//			}
//		}
//
//		newPos = checkPos;
//		return true;
//	}
//	void SmoothLookAt()
//	{
//		Vector3 relPlayerPosition = player.position - transform.position;
//		Quaternion LookAtRotation = Quaternion.LookRotation (relPlayerPosition, Vector3.up);
//		transform.rotation = Quaternion.Lerp (transform.rotation,LookAtRotation,smooth * Time.deltaTime);
//	}
}
