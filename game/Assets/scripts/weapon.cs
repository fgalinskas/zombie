using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class weapon : MonoBehaviour {
    public ParticleSystem shot;
    public ParticleSystem shot_expl;
    public int bolsa = 50;
    public int ammo = 12;
    public int ammoEx;
    public int lifeZombie = 5;
    public float hitForce = 100f;
    public bool semMunicao = false;
    public bool semMunicao2 = false;
    public bool recarregar = false;

    public Animator weaponAnim;

    public AudioSource shotSound;
    public AudioSource reloadSound;

    //public ParticleSystem shot_expl1;

    //ponto de emissao da particula
    public GameObject gunPoint;

	// Use this for initialization
	void Start () {
        PlayerPrefs.SetInt("recaregar", 0);
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Fire1") && ammo > 0 && Time.timeScale == 1)
        {
            ammo--;
            shot.Emit(1);
            shotSound.Play(0);
           
            weaponAnim.SetBool("shot", true);
            //shot_expl.Emit(1);
            //shot_expl1.Emit(1);
            RaycastHit hit;

            if (Physics.Raycast(gunPoint.transform.position, gunPoint.transform.forward, out hit))
            {


                Debug.DrawLine(gunPoint.transform.position, hit.point);
                hit.collider.gameObject.SendMessageUpwards("Damage", SendMessageOptions.DontRequireReceiver);
                if (hit.rigidbody)
                {
                    // hit.rigidbody.AddForce(-hit.normal * hitForce);
                    //lifeZombie--;
                    print("acertei");
                }
            }

        }
       
        if (Input.GetButtonUp("Fire1") && ammo > 0 && Time.timeScale == 1) {
            weaponAnim.SetBool("shot", false);
        }

            if (ammo < 10 && bolsa > 1)
        {
            semMunicao2 = true;
        }

        if (semMunicao)
        {
            if (Input.GetKeyDown(KeyCode.R) && semMunicao == true && Time.timeScale == 1)
            {
                reloadSound.Play(0);
                ammo = ammo + 10;
                bolsa = bolsa - 10;
                semMunicao = false;
            }            

        }

        if (semMunicao2)
        {
            if (Input.GetKeyDown(KeyCode.R) && semMunicao2 == true && Time.timeScale == 1)
            {
                weaponAnim.SetBool("reload", true);

                reloadSound.Play(0);
                ammoEx = 10 - ammo;
                //ammoEx = 10 - ammoEx;
                ammo = ammo + ammoEx;

                bolsa = bolsa - ammoEx;
                semMunicao2 = false;
            }
            else {
                weaponAnim.SetBool("reload", false);
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
    public void reloadRifleEnd() {

    }
   
    
}
