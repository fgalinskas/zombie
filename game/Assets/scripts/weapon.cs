using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour {
    public ParticleSystem shot;
    public ParticleSystem shot_expl;
    //public ParticleSystem shot_expl1;

    //ponto de emissao da particula
    public GameObject gunPoint;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1")) {

            shot.Emit(1);
            shot_expl.Emit(1);
            //shot_expl1.Emit(1);
            RaycastHit hit;
            if (Physics.Raycast(gunPoint.transform.position, gunPoint.transform.forward, out hit)) {
                
                Debug.DrawLine(gunPoint.transform.position, hit.point);
                hit.collider.gameObject.SendMessageUpwards("Damage", SendMessageOptions.DontRequireReceiver);
                
            }
        }
	}
}
