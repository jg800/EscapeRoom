using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowText : MonoBehaviour {
    public GameObject theText;
    // Use this for initialization
    void Start () {
        theText.SetActive(false);
	}

    public void ShowTheText() {
        if (theText.active)
        {
            theText.SetActive(false);
        }
        else {
            theText.SetActive(true);
        }

    }
}
