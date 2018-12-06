using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class final : MonoBehaviour {


    public GameObject brake;
    public Animator animTrain;
	// Use this for initialization
	void Start () {
        PlayerPrefs.SetInt("tremChegou", 0);
	}
	
	// Update is called once per frame
	void Update () {
        if (PlayerPrefs.GetInt("tremChegou") == 1)
        {
            animTrain.SetBool("end", true);
            brake.SetActive(true);
        }
    }

   
    
}
