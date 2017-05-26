using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class readysceneManager : MonoBehaviour {

    public GameObject mainPanel;
    public GameObject settingPanel;

	// Use this for initialization
	void Awake () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void settingButtonClicked() {
        cleanScreen();
        settingPanel.SetActive(true);
    }

    public void collectionButtonClicked()
    {
        cleanScreen();

    }

    public void diceButtonClicked()
    {

        cleanScreen();
    }

    public void ballcollButtonClicked()
    {
        cleanScreen();
    }

    public void startButtonClicked() {

        Debug.Log("스타트");
    
    }

    void cleanScreen() {
        mainPanel.gameObject.SetActive(false);
    }
}
