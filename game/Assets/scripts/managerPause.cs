using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;

public class managerPause : MonoBehaviour {

    public PostProcessingProfile efeito;
    public float focus_distance;
    public float focal_length;
    public GameObject pause;
    public bool pauseCheck = false;
    
	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0;
            pause.SetActive(true);
        }
    }

    public void OpenPause()
    {
        Cursor.lockState = CursorLockMode.None;
        
        
        
        //ativa o efeito de desfoque

        //cria uma variavel para armazenzar o valor
        var focus = efeito.depthOfField.settings;
        focus.focusDistance = focus_distance = 0.1f;
        efeito.depthOfField.settings = focus;

        var focal = efeito.depthOfField.settings;
        focal.focalLength = focal_length = 300f;
        efeito.depthOfField.settings = focal;

    }



    public void ClosePause()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;
        //Invoke("tempoNormal", 2);
        pause.SetActive(false);
        
        //cria uma variavel para armazenzar o valor
        var focus = efeito.depthOfField.settings;
        focus.focusDistance = focus_distance = 10f;
        efeito.depthOfField.settings = focus;

        var focal = efeito.depthOfField.settings;
        focal.focalLength = focal_length = 5f;
        efeito.depthOfField.settings = focal;
    }

    public void continuePause() {
        pause.SetActive(false);
        Time.timeScale = 1;
        Cursor.visible = false;


    }
}
