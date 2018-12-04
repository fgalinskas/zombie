using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IAcontrol : MonoBehaviour {

    public GameObject tgt; //target
    Rigidbody playerrdb;

    NavMeshAgent agent;
	//public GameObject gotoposition;
    GameObject player;
    Transform pos;

    Animator anim;

    
    void Start()
    {
        //player = GameObject.FindWithTag("Player");
        //pos = player.GetComponent<Transform>();
        
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }
	
	
	void Update () {
        
        agent.destination = tgt.transform.position;
	}

    public void Damage() {

        anim.enabled = false;
        agent.enabled = false;
        Destroy(gameObject,5);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            tgt = other.gameObject;
                 
        }
    }
}
