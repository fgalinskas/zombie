using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevator : MonoBehaviour
{

    bool playerInside = false;
    public int floor = 0;
    public Vector3[] floorposition;

    public Animator[] floordoor;
    public Animator myDoor;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, floorposition[floor], Time.deltaTime);

        if (Vector3.Distance(transform.position, floorposition[floor]) < 0.1f)
        {
            myDoor.SetBool("opened", true);
            floordoor[floor].SetBool("opened", true);
            CancelInvoke("Translating");

        }
    }

    public void Translating() {
        transform.position = Vector3.Lerp(transform.position, floorposition[floor], Time.deltaTime);

        if (Vector3.Distance(transform.position, floorposition[floor]) < 0.1f)
        {
            myDoor.SetBool("opened", true);
            floordoor[floor].SetBool("opened", true);
            CancelInvoke("Translating");

        }
    }
    public void ChangeLevel(int golevel)
    {
        if (playerInside == true) {
            floordoor[floor].SetBool("opened", false);
            myDoor.SetBool("opened", false);
            if (golevel >= 0 && golevel < floorposition.Length)
            {
                floor = golevel;
            }
            InvokeRepeating("Translating", 1, 0.01f);
        } 
    }

    public void ChangeLevelFloor(int golevel)
    {
       
            floordoor[floor].SetBool("opened", false);
            myDoor.SetBool("opened", false);
            if (golevel >= 0 && golevel < floorposition.Length)
            {
                floor = golevel;
            }
            InvokeRepeating("Translating", 1, 0.01f);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.transform.parent = transform;
        playerInside = true;
    }

    private void OnTriggerExit(Collider other)
    {
        playerInside = false;
        other.gameObject.transform.parent = null;
    }
}
