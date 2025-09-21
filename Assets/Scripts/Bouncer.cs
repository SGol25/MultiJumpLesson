using UnityEngine;

public class Bouncer : MonoBehaviour
{
    public float Jump = 100;

    void OnCollisionEnter(Collision other)
    {
        // ���������, ��� ��� �����
        if (other.gameObject.TryGetComponent<PlayerController>(out var player))
        {
            // ����� �������
            Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddForce(Vector3.up * Jump);
            }
        }
    }
}
