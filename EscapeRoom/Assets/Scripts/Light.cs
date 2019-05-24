using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Light : MonoBehaviour {
	public Image light;
	public Sprite greenLight;

	void Start() {
		Debug.Log("Light start");
		GameObject finder = GameObject.Find("BackGround(1)");
		GameInfo gaminfo = finder.GetComponent<GameInfo>();
		int[] levels = gaminfo.getLevels();
		int thisLevel = SceneManager.GetActiveScene().buildIndex;
		if (thisLevel == 2 && levels[0] == 1) {
			light.sprite = greenLight;
		} else if(thisLevel == 4 && levels[1] == 1) {
			light.sprite = greenLight;
		} else if (thisLevel == 5 && levels[2] == 1) {
			light.sprite = greenLight;
		}
	}
	public void setGreen() {
		light.sprite = greenLight;
	}
}
