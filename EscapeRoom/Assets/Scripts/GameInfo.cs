using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameInfo : MonoBehaviour
{
	public static int[] levels;
    void Start()
    {
		if (SceneManager.GetActiveScene().buildIndex == 0)
		{
			levels = new int[] { 0, 0, 0 };
		} else {
			Debug.Log("there should be numbers below...");
			for (int i = 0; i < levels.Length; i++) {
				Debug.Log(levels[i]);
			}
		}
    }

    public void doneLevel(int levelNum) {
        levels[levelNum] = 1;
		GameObject finder = GameObject.Find("Light");
		Light sceneLight = finder.GetComponent<Light>();
		sceneLight.setGreen();
	}

	public int[] getLevels() {
		return levels;
	}

    public bool checkLevels()
    {
		for (int i = 0; i < levels.Length; i++)
        {
            if (levels[i] == 0) {
                return false;
            }
        }
        return true;
    }
}
