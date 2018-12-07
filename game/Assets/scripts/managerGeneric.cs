using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managerGeneric : MonoBehaviour {

    private void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 1;
        //pause.SetActive(true);
    }
    public void cenaToGo(string cena)
    {
        myLoad.Loading(cena);
    }
}
