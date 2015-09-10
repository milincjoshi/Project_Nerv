using UnityEngine;
using System.Collections;

public class Simple_agent : MonoBehaviour {
	
	public Transform target;
	NavMeshAgent agent;
	GameObject player;

	void Awake()
	{
		agent = GetComponent<NavMeshAgent>();
		player = GameObject.FindGameObjectWithTag ("Player");
		agent.transform.position = player.transform.position;
	}
	void Start () 
	{
		agent = GetComponent<NavMeshAgent>();
		player = GameObject.FindGameObjectWithTag ("Player");
		agent.transform.position = player.transform.position;

	}
	
	void Update ()
	{
		agent.SetDestination (target.position);
		agent.CalculatePath(target.position,agent.path);

		GameObject container = new GameObject();
		container.transform.position = agent.transform.position;
		container.transform.parent = agent.gameObject.transform;
		
		LineRenderer ligne = container.AddComponent<LineRenderer>();
		Vector3 height = new Vector3(0,1f,0);

		//ligne.transform.position = ligne.transform.position + height;

		ligne.SetColors(Color.white,Color.white);
		ligne.SetWidth(0.1f,0.1f);
		//Get def material
		ligne.gameObject.GetComponent<Renderer>().material.color = Color.green;
		ligne.gameObject.GetComponent<Renderer>().material.shader = Shader.Find("Sprites/Default");
		ligne.gameObject.AddComponent<LineScript>();
		ligne.gameObject.tag = "ligne";
		ligne.enabled = false;
	}
}
