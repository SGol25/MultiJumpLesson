using UnityEngine;

public class Bouncer : MonoBehaviour
{
    public float Jump = 100;

    void OnCollisionEnter(Collision other)
    {
        // Проверяем, что это игрок
        if (other.gameObject.TryGetComponent<PlayerController>(out var player))
        {
            // Игрок прыгает
            Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddForce(Vector3.up * Jump);
            }
        }
    }
}
