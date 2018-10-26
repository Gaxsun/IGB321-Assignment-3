using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUI_Controller : MonoBehaviour {

    public GameObject journalUI;
    public Text journalUIText;
    public int levelJournals;
    private int journalCounter = 0;

    public GameObject objectiveUI;
    private bool objectiveOpen;
    public Toggle[] objectiveToggles;

    public GameObject player;

    public int levelID;
    public GameObject winScreen;

	// Use this for initialization
	void Start () {
        journalUI.SetActive(false);
        objectiveUI.GetComponent<CanvasGroup>().alpha = 0f;
        if (levelID == 3)
        {
            winScreen.SetActive(false);
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (GameObject.FindGameObjectWithTag("loadnextscene").GetComponent<goToNextScene>().allDemonsDead == true)
        {
            objectiveToggles[5].isOn = true;
            if (levelID == 3)
            {
                winScreen.SetActive(true);
            }
        }
        objectiveToggles[7].GetComponentInChildren<Text>().text = journalCollectionText();
        objectiveToggles[5].GetComponentInChildren<Text>().text = demonLureText();
    }

    public void journalOpen (string journalText)
    {
        journalUIText.text = journalText;
        journalUI.SetActive(true);
        player.GetComponent<Player>().moveLock = true;
        journalCounter += 1;
        if (journalCounter == levelJournals)
        {
            objectiveToggles[7].isOn = true;
        }
    }

    public void journalClose()
    {
        journalUI.SetActive(false);
        journalUIText.text = "Journal Closed";
        player.GetComponent<Player>().moveLock = false;
    }

    public void objectiveToggle()
    {
        if (objectiveOpen)
        {
            objectiveUI.GetComponent<CanvasGroup>().alpha = 0f;
            objectiveOpen = false;
        }
        else
        {
            objectiveUI.GetComponent<CanvasGroup>().alpha = 1f;
            objectiveOpen = true;
        }
    }

    public void circleFindObjectvieUpdate()
    {
        if (objectiveToggles[0].isOn == false)
        {
            objectiveToggles[0].isOn = true;
        }
    }

    public void itemObjectiveUpdate(string itemType)
    {
        if (itemType == "bible")
        {
            objectiveToggles[1].isOn = true;
        }
        else if (itemType == "cross")
        {
            objectiveToggles[2].isOn = true;
        }
        else if (itemType == "candle")
        {
            objectiveToggles[3].isOn = true;
        }
    }

    public void repairObjectiveUpdate()
    {
        objectiveToggles[4].isOn = true;
    }

    private string journalCollectionText()
    {
        return "Collect Journals: (" + journalCounter.ToString() + "/" + levelJournals.ToString() + ")";
    }

    private string demonLureText()
    {
        return "Lure the Demons: (" + GameObject.FindGameObjectWithTag("Goal").GetComponent<BringItemsBack>().demonsDead + "/" + GameObject.FindGameObjectWithTag("Goal").GetComponent<BringItemsBack>().numOfDemons + ")";
    }
}
