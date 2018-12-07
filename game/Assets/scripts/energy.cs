using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class energy : MonoBehaviour {

    public AudioSource lighIsOn;
    //public elevator other;
    bool playerInside = false;
    //public GameObject painel;
    //public int numeroAndar;
    public GameObject questLog_0;
    public GameObject questLog_1;

    public GameObject botaoE;
    // Use this for initialization
    void Start()
    {
        PlayerPrefs.SetInt("andar", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInside)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                PlayerPrefs.SetInt("luz", 1);
                questLog_0.SetActive(false);
                questLog_1.SetActive(true);
                lighIsOn.Play(0);
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
}
