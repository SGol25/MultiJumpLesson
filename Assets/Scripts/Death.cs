using UnityEngine;

public class Death : MonoBehaviour
{
    private GameObject Player;
    
    private void Start()
    {
        Player = GameObject.Find("Player");
        
    }

    void OnTriggerEnter(Collider other)
    {
        // Проверяем, что это игрок
        if (other.TryGetComponent<PlayerController>(out var player))
        {

            // Телепортируем его на старт
            Debug.Log("Игрок умер");
            Player.transform.position = new Vector3(-17f, 2f, 0.8f);

        }

    }
}
