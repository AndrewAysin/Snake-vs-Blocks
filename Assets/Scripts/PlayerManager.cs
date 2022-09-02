using UnityEngine.SceneManagement;
using UnityEngine;


public class PlayerManager : MonoBehaviour
{
    public static bool isGameOver;
    public static bool isGameWin;
    public static bool isGamePaused;
    public GameObject gameOverScreen;
    public GameObject gameWinScreen;
    public GameObject gamePauseScreen;

    private void Awake()
    {
        isGameOver = false;
        isGameWin = false;
        
    }

    void Update()
    {
        if (isGameOver)
        {
            gameOverScreen.SetActive(true);
        }
        if (isGameWin)
        {
            gameWinScreen.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isGamePaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    void Pause()
    {
        gamePauseScreen.SetActive(true);
        Time.timeScale = 0f;
        isGamePaused = true;
    }
    public void Resume()
    {
        gamePauseScreen.SetActive(false);
        Time.timeScale = 1f;
        isGamePaused = false;
    }
    public void ReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void LoadFirstLvl()
    {
        SceneManager.LoadScene("Level_1");
    }
    public void LoadFirstLv2()
    {
        SceneManager.LoadScene("Level_2");
    }
    public void LoadFirstLv3()
    {
        SceneManager.LoadScene("Level_3");
    }
    public void LoadFirstLv4()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void Quit()
    {
        Application.Quit();
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }



}
