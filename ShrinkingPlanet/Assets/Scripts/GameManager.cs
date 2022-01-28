using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager instance;

    public GameObject gameOverUI, rightTurn, leftTurn, restartButton, menuButton;

	void Awake ()
	{
		instance = this;
        rightTurn.SetActive(true);
        leftTurn.SetActive(true);
    }

	public void EndGame ()
	{
		gameOverUI.SetActive(true);
        rightTurn.SetActive(false);
        leftTurn.SetActive(false);
        restartButton.SetActive(true);
        menuButton.SetActive(true);
    }

	public void Restart ()
	{
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        rightTurn.SetActive(true);
        leftTurn.SetActive(true);
        restartButton.SetActive(false);
        menuButton.SetActive(false);
    }

    public void Menu ()
    {
        SceneManager.LoadScene("Menu");
        rightTurn.SetActive(false);
        leftTurn.SetActive(false);
        restartButton.SetActive(false);
        menuButton.SetActive(false);
    }
}
