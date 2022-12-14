using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverScreen;
    [SerializeField] private GameObject VictoryScreen;
    [SerializeField] private GameObject HealthUIHolder;
    [SerializeField] private AudioClip gameOverSound;
    [SerializeField] private AudioClip gameOverSound2;

    private void Awake()
    {
        gameOverScreen.SetActive(false);
        VictoryScreen.SetActive(false);
        HealthUIHolder.SetActive(true);
    }

    #region Game Over Functions
    //Game over function
    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        HealthUIHolder.SetActive(false);
        VictoryScreen.SetActive(false);
        SoundManager.instance.PlaySound(gameOverSound2);
        SoundManager.instance.PlaySound(gameOverSound);
    }

    //Restart level
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    //Activate game over screen
    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    //Quit game/exit play mode if in Editor
    public void Quit()
    {
        Application.Quit(); //Quits the game (only works in build)

        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; //Exits play mode
        #endif
    }
    #endregion
}