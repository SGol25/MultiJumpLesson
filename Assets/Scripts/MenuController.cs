using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Этот метод можно вызвать через OnClick Events
    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene"); // SampleScene - это название файла сцены, которая откроется
    }

    public void ExitGame()
    {
        Application.Quit(); // Выход из игры
    }
}