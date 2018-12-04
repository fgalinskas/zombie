using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactive : MonoBehaviour {

    //public elevator other;
    bool playerInside = false;
    public GameObject painel;
    //public int numeroAndar;
    
    public GameObject botaoE;
	// Use this for initialization
	void Start () {
        //PlayerPrefs.SetInt("andar", 0);
    }
	
	// Update is called once per frame
	void Update () {
        if (playerInside) {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Cursor.visible = true;
                painel.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
                Time.timeScale = 0;                

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

    public void sairPainel() {
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;
        painel.SetActive(false);
        Cursor.visible = false;
    }
}
