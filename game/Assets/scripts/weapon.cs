using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class weapon : MonoBehaviour {
    public ParticleSystem shot;
    public ParticleSystem shot_expl;

    public int ammo = 12;
    public int lifeZombie = 5;
    public float hitForce = 100f;


    //public ParticleSystem shot_expl1;

    //ponto de emissao da particula
    public GameObject gunPoint;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetButtonDown("Fire1") && ammo > 0) {
            ammo--;
            shot.Emit(1);
            //shot_expl.Emit(1);
            //shot_expl1.Emit(1);
            RaycastHit hit;
            
            if (Physics.Raycast(gunPoint.transform.position, gunPoint.transform.forward, out hit)) {


                Debug.DrawLine(gunPoint.transform.position, hit.point);

                if (hit.rigidbody) {
                    hit.rigidbody.AddForce(-hit.normal * hitForce);
                    lifeZombie--;
                    print("acertei");
                    
                }

                if (lifeZombie <= 0) {
                    hit.collider.gameObject.SendMessageUpwards("Damage", SendMessageOptions.DontRequireReceiver);
                } 
            }
        }
	}

    
}
