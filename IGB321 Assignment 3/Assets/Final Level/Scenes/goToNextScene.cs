using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goToNextScene : MonoBehaviour {

    public int circleCounter = 0;
    public GameObject doorToUnlock;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (circleCounter >= 3) {
            doorToUnlock.GetComponent<DoorAnimation>().locked = false;
        }
	}

    public void OnTriggerEnter(Collider other) {

        if (other.tag == "Player") {
            SceneManager.LoadScene("Level Two", LoadSceneMode.Additive);
        }
    }
}
