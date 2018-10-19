using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimation : MonoBehaviour {

    public GameObject doorPositive;
    public GameObject doorNegative;

    public bool open = false;
    public bool locked = false;

    private Animation doorAnimPositive;
    private Animation doorAnimNegative;

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
        
    }

    public void DoorInteract()
    {
        if ((!doorAnimPositive.isPlaying || !doorAnimNegative.isPlaying) && !locked)
        {
            if (!open)
            {
                doorAnimPositive.Play("PositiveDoorOpen");
                doorAnimNegative.Play("NegativeDoorOpen");
                open = true;
            }
            else
            {
                doorAnimPositive.Play("PositiveDoorClose");
                doorAnimNegative.Play("NegativeDoorClose");
                open = false;
            }
        }
    }
}
