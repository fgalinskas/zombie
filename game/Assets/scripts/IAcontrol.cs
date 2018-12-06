using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IAcontrol : MonoBehaviour {

    //public GameObject playerWeaponRef;
    public GameObject morte;
    public Collider col;
    public GameObject tgt; //target
    Rigidbody playerrdb;
    public bool lifeCheck = false;
    public int life = 10;
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
        //print(tgt.GetComponent<weapon>().lifeZombie);
        if (life > 0) {
           
        }
        
	}

    public void Damage() {
       
            life--;

        if (life <= 0) {
            anim.enabled = false;
            agent.enabled = false;
            Destroy(gameObject, 2);
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            tgt = other.gameObject;
            agent.destination = tgt.transform.position;
            Destroy(col);
            

            //col.enabled = false;
            Invoke("morteTela", 2);
        }
    }

    public void morteTela() {
        morte.SetActive(true);

    }
}
