using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour {

    public string level;
    public Animator fadeAnim;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void levelStart() {
        Invoke("cenaToGo", 3);
        fadeAnim.SetBool("fade", false);
    }

    public void cenaToGo() {
        myLoad.Loading(level);
    }
}
