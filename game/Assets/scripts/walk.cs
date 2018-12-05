using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour {

    public AudioSource walkSound;
  
    public void IsMoving()
    {
        //aqui coloca o som walk
        walkSound.Play(0);
    }
}
