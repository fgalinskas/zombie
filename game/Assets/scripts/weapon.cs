using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class weapon : MonoBehaviour {
    public ParticleSystem shot;
    public ParticleSystem shot_expl;
    public int bolsa = 50;
    public int ammo = 12;
    public int lifeZombie = 5;
    public float hitForce = 100f;
    public bool semMunicao = false;
    public bool recarregar = false;

    //public ParticleSystem shot_expl1;

    //ponto de emissao da particula
    public GameObject gunPoint;

	// Use this for initialization
	void Start () {
        PlayerPrefs.SetInt("recaregar", 0);
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
                hit.collider.gameObject.SendMessageUpwards("Damage", SendMessageOptions.DontRequireReceiver);
                if (hit.rigidbody) {
                   // hit.rigidbody.AddForce(-hit.normal * hitForce);
                    //lifeZombie--;
                    print("acertei");
                    
                }                
            }
            
        }

        if (ammo == 0)
        {
            semMunicao = true;
        }

        if (semMunicao)
        {
            if (Input.GetKeyDown(KeyCode.R) && bolsa >=1)
            {
                ammo = ammo + 10;
                bolsa = bolsa - 10;
                semMunicao = false;
            }

        }

        if (PlayerPrefs.GetInt("recarregar") == 1) {
            recarregar = true;
            
        }

        if (recarregar) {            
            bolsa = bolsa + 10;
            recarregar = false;
            PlayerPrefs.SetInt("recarregar", 0);

        }
    }

    
}
