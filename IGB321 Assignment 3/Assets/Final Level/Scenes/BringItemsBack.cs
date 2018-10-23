using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BringItemsBack : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter(Collider other) {

        if (other.tag == "Player") {
            GameObject[] collectables = GameObject.FindGameObjectsWithTag("collectable");
            print("(.)(.)");
            foreach (GameObject i in collectables) {
                if (i.transform.position == new Vector3(100,0,100)) {
                    print(i.transform.position);
                    i.GetComponent<collectableItem>().sendToCircle();
                }
            }
        }
    }
}
