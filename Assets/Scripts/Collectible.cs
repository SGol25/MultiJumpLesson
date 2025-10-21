using Unity.VisualScripting;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    private CountCoins CountCoins;
    public GameObject effect;

    private void Start()
    {
        CountCoins = FindAnyObjectByType<CountCoins>();
        effect.SetActive(false);

    }

    void OnTriggerEnter(Collider other)
    {
        // Проверяем, что это игрок
        if (other.TryGetComponent<PlayerController>(out var player))
        {

            // Уничтожаем объект
            Destroy(gameObject);

            effect.SetActive(true);

            CountCoins.AddCoins();
        }

    }
}
