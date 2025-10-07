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
        // ���������, ��� ��� �����
        if (other.TryGetComponent<PlayerController>(out var player))
        {

            // ���������� ������
            Destroy(gameObject);

            CountCoins.AddCoins();
        }

    }
}
