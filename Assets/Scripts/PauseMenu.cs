using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pausePanel;

    private bool isPaused = false;

    void Start()
    {
        // ��������, ��� ������ ��������� ��� ������
        if (pausePanel != null)
            pausePanel.SetActive(false);
    }

    void Update()
    {
        // ��������� ������� ������� ESC
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
                Resume();
            else
                Pause();
        }
    }

    public void Pause()
    {
        if (pausePanel != null)
            pausePanel.SetActive(true);

        Time.timeScale = 0f; // ������������� �����
        isPaused = true;
    }

    public void Resume()
    {
        if (pausePanel != null)
            pausePanel.SetActive(false);

        Time.timeScale = 1f; // ���������� �����
        isPaused = false;
    }

    // ����� � ����
    public void QuitToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    // ������� ����
    public void Restart()
    {
        Resume();
        SceneManager.LoadScene("SampleScene");
    }
}
