using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour {

    public GameObject playerRef;
	// Use this for initialization
	void Start () {
        Instantiate(playerRef, transform.position, transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
