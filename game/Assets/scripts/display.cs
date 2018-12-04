using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class display : MonoBehaviour {
   
    public Text ammoCount;
    public Text bolsaCount;
    int ammo2;
    public GameObject player;
    // Use this for initialization
    void Start () {
        
       // ammo2 = GameObject.FindWithTag("Respawn").GetComponent<w;

    }

    // Update is called once per frame
    void Update () {
        diplayAmmo();
    }

    void diplayAmmo()
    {
        ammoCount.text = "Count: " + player.GetComponent<weapon>().ammo;
        bolsaCount.text = "Count: " + player.GetComponent<weapon>().bolsa;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player = other.gameObject;

        }
    }
}
