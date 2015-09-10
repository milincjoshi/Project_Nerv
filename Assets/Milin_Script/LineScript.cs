using UnityEngine;
using System.Collections;

public class LineScript : MonoBehaviour {

	void Update () {
		float dist=this.transform.parent.GetComponent<NavMeshAgent>().remainingDistance;
		if (dist != Mathf.Infinity && this.transform.parent.GetComponent<NavMeshAgent>().pathStatus == NavMeshPathStatus.PathComplete && this.transform.parent.GetComponent<NavMeshAgent>().remainingDistance == 0)
			Destroy (gameObject);
		
		this.GetComponent<LineRenderer>().SetVertexCount(this.transform.parent.GetComponent<NavMeshAgent>().path.corners.Length);
		int i = 0;
		foreach(Vector3 v in this.transform.parent.GetComponent<NavMeshAgent>().path.corners)
		{
			this.GetComponent<LineRenderer>().SetPosition(i,v);
			i++;
		}
		if (this.GetComponent<LineRenderer> ().enabled == false)
			this.GetComponent<LineRenderer> ().enabled = true;
	}
}
