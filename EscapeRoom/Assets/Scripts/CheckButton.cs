using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class CheckButton : MonoBehaviour
{
	public GameInfo theGame;
	public int nextLevel;

	private void Start()
	{
		GameObject finder = GameObject.Find("BackGround(1)");
		theGame = finder.GetComponent<GameInfo>();
	}

	public void check() {
		Debug.Log("Chec = "+theGame.checkLevels());
		if (theGame.checkLevels()) {
			SceneManager.LoadScene(nextLevel);
		}
	}
}