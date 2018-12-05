using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lastCheck : MonoBehaviour {

    //public elevator other;
    bool playerInside = false;
    //public GameObject painel;

    //public int numeroAndar;

    //public GameObject botaoE;
    // Use this for initialization
    void Start()
    {
        PlayerPrefs.SetInt("final", 0);
        //PlayerPrefs.SetInt("andar", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInside)
        {
            PlayerPrefs.SetInt("final", 1);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        playerInside = true;
    }

    public void OnTriggerExit(Collider other)
    {
        playerInside = false;
    }
}
