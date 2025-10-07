using UnityEngine;

public class Collectible : MonoBehaviour
{
    private CountCoins CountCoins;

    private void Start()
    {
        CountCoins = FindAnyObjectByType<CountCoins>();
    }

    void OnTriggerEnter(Collider other)
    {
        // Проверяем, что это игрок
        if (other.TryGetComponent<PlayerController>(out var player))
        {

            // Уничтожаем объект
            Destroy(gameObject);

            CountCoins.AddCoins();
        }

    }
}
