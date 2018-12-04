using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IAcontrol : MonoBehaviour {


    NavMeshAgent agent;
	public GameObject gotoposition;

    Animator anim;
	void Start () {

        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
	}
	
	
	void Update () {
        agent.destination = gotoposition.transform.position;
	}

    public void Damage() {

        anim.enabled = false;
        agent.enabled = false;
        Destroy(gameObject,5);
    }
}
