using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goToNextScene : MonoBehaviour {

    public int circleCounter = 0;
    public GameObject doorToUnlock;
    public bool allDemonsDead = false;
    public string nextLevel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (circleCounter >= 3 && allDemonsDead) {
            doorToUnlock.GetComponent<DoorAnimation>().locked = false;
        }
	}

    public void OnTriggerEnter(Collider other) {

        if (other.tag == "Player") {
            SceneManager.LoadScene(nextLevel, LoadSceneMode.Single);
        }
    }
}
