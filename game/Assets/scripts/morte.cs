using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class morte : MonoBehaviour {

    bool playerInside = false;
    public GameObject morteTela;
    // Use this for initialization
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player") {
            PlayerPrefs.SetInt("morte_0", 1);

        }


    }
}
