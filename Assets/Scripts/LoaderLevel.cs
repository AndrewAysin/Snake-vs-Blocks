
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoaderLevel : MonoBehaviour
{
    public GameObject gameOverScreen;
    public GameObject gameWinScreen;
    public GameObject gamePauseScreen;

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
}
