using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private CountCoins CountCoins;

    private void Start()
    {
        CountCoins = FindAnyObjectByType<CountCoins>();
    }

    void OnTriggerEnter(Collider other)
    {
        // Проверяем, что это игрок
        if (other.TryGetComponent<PlayerController>(out var player) && (CountCoins.currentCoins == CountCoins.MaxCoins))
        {
            SceneManager.LoadScene("MainMenu");
        }
        else if (CountCoins.currentCoins < CountCoins.MaxCoins)
        {
            Debug.Log("Собраны не все монеты!");
        }

    }
}
