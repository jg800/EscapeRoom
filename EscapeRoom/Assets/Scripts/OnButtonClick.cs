using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class OnButtonClick : MonoBehaviour
{
    public InputField[] theFields;
    public string[] expectedAnswer;
    public int nextLevel;
	public AudioClip theGoodClip;
	public AudioClip theBadClip;
	public AudioSource theSource;
	private bool hasMusic;

	public void Start() {
		if (theBadClip != null) {
			theSource.clip = theBadClip;
			hasMusic = true;
		} else {
			hasMusic = false;
		}
	}

	public void ClickedButton()
    {
		if (theFields.Length == 0)
		{
			SceneManager.LoadScene(nextLevel);
		} else if (CheckAnswer()) {
			if (hasMusic) {
				theSource.clip = theGoodClip;
				theSource.Play();
			}
			if (nextLevel >= 0) {
				bool enter = true;
				if (nextLevel == 3) {
					GameObject finder = GameObject.Find("BackGround(1)");
					GameInfo gaminfo = finder.GetComponent<GameInfo>();
					if (!gaminfo.checkLevels()) {
						enter = false;
					}
				}
				if (enter) {
					SceneManager.LoadScene(nextLevel);
				}
			} else {
				GameObject finder = GameObject.Find("BackGround(1)");
				GameInfo gaminfo = finder.GetComponent<GameInfo>();
				int myLevelNum = SceneManager.GetActiveScene().buildIndex;
				if (myLevelNum == 2) {
					gaminfo.doneLevel(0);
				} else if (myLevelNum == 4) {
					gaminfo.doneLevel(1);
				} else if (myLevelNum == 5) {
					gaminfo.doneLevel(2);
				}
			}
		} else if(hasMusic) {
			theSource.clip = theBadClip;
			theSource.Play();
		}
    }

    private bool CheckAnswer()
    {   
        for (int i = 0; i < theFields.Length; i++) {
            if (!(theFields[i].text.Equals(expectedAnswer[i]))) {
                return false;
            }
        }
        return true;
    }
}