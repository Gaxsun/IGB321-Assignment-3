using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectableItem : MonoBehaviour {

    public GameObject CollectionLocation;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other) {
        print(other.tag);
        if (other.tag == "Player") {
            GameObject.FindGameObjectWithTag("loadnextscene").GetComponent<goToNextScene>().circleCounter++;
            //transform.position = CollectionLocation.transform.position;
            transform.position = new Vector3(100,0,100);
        }
    }

    public void sendToCircle() {
        transform.position = CollectionLocation.transform.position;
        GetComponent<BoxCollider>().enabled = false;
    }
}
