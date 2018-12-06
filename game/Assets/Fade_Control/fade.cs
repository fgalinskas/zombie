using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fade : MonoBehaviour {

    public string cenaFinal;
    public Animator anim;


	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        anim.SetBool("fade", true);
	}
	
	// Update is called once per frame
	void Update () {
        if (PlayerPrefs.GetInt("final") == 1)
        {
            anim.SetBool("fade", false);
            Invoke("cenaToGo", 4);
        }

    }

    public void cenaToGo()
    {
        myLoad.Loading(cenaFinal);
    }

    public void fadeOutAnim() {
        anim.SetBool("fade", false);
        Invoke("cenaToGo", 3);
    }
}
