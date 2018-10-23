using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DoorAnimation : MonoBehaviour {

    public GameObject doorPositive;
    public GameObject doorNegative;

    public bool open = false;
    public bool locked = false;
    public bool DemonLocked = false;

    private Animation doorAnimPositive;
    private Animation doorAnimNegative;

    public NavMeshObstacle loch;

    private void Start()
    {
        //Retrieves the animations for both doors if they are assigned. Script works for both single and double doors

        //Retrieve positive 90 degree animation
        if (doorPositive != null)
        {
            doorAnimPositive = doorPositive.GetComponent<Animation>();
        }
        //Retrieve negative 90 degree animation
        if (doorNegative != null)
        {
            doorAnimNegative = doorNegative.GetComponent<Animation>();
        }
        loch = this.gameObject.GetComponent<NavMeshObstacle>();
    }

    void Update() {
        if (locked) {
            loch.enabled = true;
        }
    }

    public void DoorInteract()
    {

        if (!doorAnimNegative.isPlaying && !locked)
        {
            if (!open)
            {
                doorAnimNegative.Play("NegativeDoorOpen");
                open = true;
            }
            else
            {
                doorAnimNegative.Play("NegativeDoorClose");
                open = false;
            }
        }

        if (doorAnimPositive != null) {
            if (!doorAnimPositive.isPlaying && !locked) {
                if (!open) {
                    doorAnimPositive.Play("PositiveDoorOpen");
                    open = true;
                } else {
                    doorAnimPositive.Play("PositiveDoorClose");
                    open = false;
                }
            }
        }
    }

    void OnTriggerEnter(Collider other) {
        print(other.tag);
        if (other.tag == "Player") {
            DoorInteract();
        }
    }

}
