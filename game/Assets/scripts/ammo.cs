﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammo : MonoBehaviour {

    public AudioSource catchSound;
    bool playerInside = false;
    public GameObject botaoE;
    //public GameObject player;
    int bolsa;
    int bolsaRecar = 10;
    // Use this for initialization
    void Start () {
        PlayerPrefs.SetInt("recarregar", 0);
        //player = GameObject.FindWithTag("Player");
        //bolsa = player.GetComponent<weapon>().bolsa;

    }
	
	// Update is called once per frame
	void Update () {
        //print(bolsa);
        //player.GetComponent<weapon>().bolsa = bolsa;
        if (playerInside)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                PlayerPrefs.SetInt("recarregar", 1);
                catchSound.Play(0);
                Invoke("desativar", 0.5f);

            }
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        playerInside = true;
        botaoE.SetActive(true);
    }

    public void OnTriggerExit(Collider other)
    {
        playerInside = false;
        botaoE.SetActive(false);
    }

    public void desativar() {
        gameObject.SetActive(false);
    }
}
