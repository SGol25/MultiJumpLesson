using UnityEngine;

public class Death : MonoBehaviour
{
    private GameObject Player;
    private HealthManager healthmanager;
    
    private void Start()
    {
        Player = GameObject.Find("Player");
        healthmanager = FindAnyObjectByType<HealthManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        // ���������, ��� ��� �����
        if (other.TryGetComponent<PlayerController>(out var player))
        {

            // ������������� ��� �� �����
            Debug.Log("����� ����");
            Player.transform.position = new Vector3(-17f, 2f, 0.8f);

            healthmanager.LoseHp();

        }

    }
}
