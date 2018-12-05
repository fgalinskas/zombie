using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.AI;

public class ordas : MonoBehaviour {

    public GameObject zombie;
    public GameObject zombie1;
    public GameObject zombie2;
    public GameObject nest;
    public int numeroZombies;
    public int countZombie = 0;
    public bool orda_0 = false;
    public bool orda_1 = false;
    public bool orda_2 = false;

    public int cooldownOrda1 = 5;
    public int cooldownOrda2 = 20;
    public int cooldownOrda3 = 40;
    public int cooldownfinal = 60;
    void Start () {
        PlayerPrefs.SetInt("luz", 0);

    }

	void Update () {
        if (PlayerPrefs.GetInt("luz") == 1) {
            orda_0 = true;
            PlayerPrefs.SetInt("luz", 0);
        }
        if (orda_0) {
            numeroZombies = 3;
            Invoke("spawn", cooldownOrda1);
        }

        if (orda_1)
        {
            numeroZombies = 4;
            Invoke("spawn1", cooldownOrda2);
            
        }

        if (orda_2)
        {
            numeroZombies = 5;
            Invoke("spawn2", cooldownOrda3);
        }
    }

    public void spawn() {
        if (orda_0) {            
            Instantiate(zombie, nest.transform);
            countZombie++;
        }

        if (numeroZombies == countZombie)
        {
            orda_0 = false;
            orda_1 = true;
            countZombie = 0;
        }
    }

    public void spawn1()
    {
        if (orda_1)
        {
            Instantiate(zombie1, nest.transform);
            countZombie++;            
        }
        if (numeroZombies == countZombie)
        {
            orda_1 = false;
            orda_2 = true;
            countZombie = 0;
            Invoke("finalJogo", cooldownfinal);
        }
    }

    public void spawn2()
    {
        if (orda_2)
        {
            Instantiate(zombie2, nest.transform);
            countZombie++;
            
        }
        if (numeroZombies == countZombie)
        {
            orda_2 = false;
            countZombie = 0;
        }
    }
    public void finalJogo() {
        PlayerPrefs.SetInt("tremChegou", 1);

    }
}
