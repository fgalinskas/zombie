using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botoes_out : MonoBehaviour {

    public Animator anim;
	// Use this for initialization
	void Start () {
        anim.SetBool("botao", true);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void sumirBotao() {
        anim.SetBool("botao", false);
    }
}
