using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BringItemsBack : MonoBehaviour {
    public int numOfDemons = 1;
    public int demonsDead = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter(Collider other) {

        if (other.tag == "Enemy" && GameObject.FindGameObjectWithTag("loadnextscene").GetComponent<goToNextScene>().circleCounter >= 3) {
            Destroy(other.gameObject);
            demonsDead++;
            if (numOfDemons <= demonsDead) {
                GameObject.FindGameObjectWithTag("loadnextscene").GetComponent<goToNextScene>().allDemonsDead = true;
                GameObject.FindGameObjectWithTag("workyabastard").GetComponent<DoorAnimation>().locked = false;
            }
            //print(this.gameObject.GetComponent<DoorAnimation>() == null);
        }

        if (other.tag == "Player") {
            GameObject[] collectables = GameObject.FindGameObjectsWithTag("collectable");
            foreach (GameObject i in collectables) {
                if (i.transform.position == new Vector3(100,0,100)) {
                    //print(i.transform.position);
                    i.GetComponent<collectableItem>().sendToCircle();
                }
            }
        }
    }
}
