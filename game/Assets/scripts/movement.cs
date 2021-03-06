﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    public AudioSource walk;
    int numeroRandom;
    public bool playerMoving = false;
    //controle camera
    public GameObject Head;
    float headAngle = 0;
    public float velocity=10f;
    public Animator walkAnim;

    CharacterController CharCtrl;
    Vector3 vecMove=Vector3.zero;
    Vector3 vecLook = Vector3.zero;

    void Start () {
         
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        CharCtrl = GetComponent<CharacterController>();	
	}
    
   
    
    void ControlPlayer() {
        //pego a tecla e salvo no vector
        vecMove = new Vector3(Input.GetAxis("Horizontal"), -1, Input.GetAxis("Vertical"));
        vecLook = new Vector3(Input.GetAxis("Mouse Y")*2, Input.GetAxis("Mouse X")*2,0 );
        headAngle -= vecLook.x;
        //limite de rotacao da camera;
        headAngle = Mathf.Clamp(headAngle, -70, 70);
               
    }

    void Update () {

        if (CharCtrl.velocity.magnitude>0)
        {
            walk.Play();
            walkAnim.SetBool("walk", true);
        }
        else {
            walk.Stop();
            walkAnim.SetBool("walk", false);
        }

        if (Time.timeScale == 1)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;

            ControlPlayer();
            CharCtrl.Move(transform.TransformDirection(vecMove * velocity));
            transform.Rotate(Vector3.up, vecLook.y);
            Head.transform.localRotation = Quaternion.Euler(headAngle, 0, 0);

        }
        else {
            walkAnim.SetBool("walk", false);
        }
    }

    void IsMoving()
    {
        //aqui coloca o som walk
        walk.volume = 0.2f;
        walk.Play(0);
        
    }

    void notMoving()
    {
        walkAnim.SetBool("walk", false);

    }



}
