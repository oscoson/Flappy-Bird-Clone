using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{

    public GameObject gameOverCanvas;
    public GameObject gameplayCanvas;
    public GameObject pauseCanvas;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;

    }

    // Update is called once per frame
    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        GameObject.Find("Bronze Medal").SetActive(true);
        GameObject.Find("Silver Medal").SetActive(true);
        GameObject.Find("Gold Medal").SetActive(true);
        GameObject.Find("Platinum Medal").SetActive(true);
        gameplayCanvas.SetActive(false);

        if(Score.score < 10)
        {
            GameObject.Find("Bronze Medal").SetActive(true);
            GameObject.Find("Silver Medal").SetActive(false);
            GameObject.Find("Gold Medal").SetActive(false);
            GameObject.Find("Platinum Medal").SetActive(false);
        }
        else if(Score.score >= 10 && Score.score < 30)
        {
            GameObject.Find("Bronze Medal").SetActive(false);
            GameObject.Find("Silver Medal").SetActive(true);
            GameObject.Find("Gold Medal").SetActive(false);
            GameObject.Find("Platinum Medal").SetActive(false);
        }
        else if(Score.score >= 30 && Score.score < 50)
        {
            GameObject.Find("Bronze Medal").SetActive(false);
            GameObject.Find("Silver Medal").SetActive(false);
            GameObject.Find("Gold Medal").SetActive(true);
            GameObject.Find("Platinum Medal").SetActive(false);
        }
        else
        {
            GameObject.Find("Bronze Medal").SetActive(false);
            GameObject.Find("Silver Medal").SetActive(false);
            GameObject.Find("Gold Medal").SetActive(false);
            GameObject.Find("Platinum Medal").SetActive(true);
        }
        // Set time to zero so nothing moves
        Time.timeScale = 0;
        

    }

    public void Replay()
    {
        SceneManager.LoadScene(1);
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene(0);
    }

    public void PauseButton()
    {
        if(!(gameOverCanvas.activeInHierarchy))
        {
            Time.timeScale = 0;
            pauseCanvas.SetActive(true);
            gameplayCanvas.SetActive(false);
        }

    }

    public void ContinueButton()
    {
        Time.timeScale = 1;
        pauseCanvas.SetActive(false);
        gameplayCanvas.SetActive(true);
    }

}
