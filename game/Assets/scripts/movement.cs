using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    //controle camera
    public GameObject Head;
    float headAngle = 0;
    public float velocity=0.1f;

    CharacterController CharCtrl;
    Vector3 vecMove=Vector3.zero;
    Vector3 vecLook = Vector3.zero;

    void Start () {
       
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

        if (Time.timeScale == 1) {
            Cursor.visible = true;
            ControlPlayer();
            CharCtrl.Move(transform.TransformDirection(vecMove * velocity));
            transform.Rotate(Vector3.up, vecLook.y);
            Head.transform.localRotation = Quaternion.Euler(headAngle, 0, 0);

        }
    }    
}
