using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentDemo : MonoBehaviour {

    private NavMeshAgent agent;
	public Transform target;
	

	void Start() {
		agent = GetComponent<NavMeshAgent>();
	}

	void Update () {
		if (target ) {
            agent.destination = target.position;
		}
	}
}
