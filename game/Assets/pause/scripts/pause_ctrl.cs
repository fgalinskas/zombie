using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause_ctrl : MonoBehaviour {

    //public GameObject pauseObject;
    public GameObject pauseObjectBotoes;
    public GameObject somObject;
    public Animator animPause;
    public GameObject PAUSE;
    Animator pause;

    GameObject botoesAnim;


    // Use this for initialization
    void Start() {
        Invoke("endPauseIn", 2);
    }

    // Update is called once per frame
    void Update() {
        
    }

    public void endPauseIn(){        
        animPause.SetBool("pause_in", true);
        pauseObjectBotoes.SetActive(true);
    }

    public void sairPause() {
        //animPause.SetBool("pause_in", false);
        Invoke("animacao", 2);
        Invoke("desativaPause", 3);

    }

    public void desativaPause() {
        PAUSE.SetActive(false);

    }

    public void animacao() {
        animPause.SetBool("pause_out", true);

    }
}
