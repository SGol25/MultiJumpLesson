using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float Speed = 2f;
    public float Distance = 3f;
    public bool Up_Down;
    private Vector3 startPos;

    void Start()
    {
        // Запоминаем начальное положение
        startPos = transform.position;
    }

    void Update()
    {
        if (Up_Down)
        {
            // Движение вверх-вниз 
            float movement = Mathf.Sin(Time.time * Speed) * Distance;
            transform.position = new Vector3(startPos.x, startPos.y + movement, startPos.z);
        }
        else
        {
            // Движение влево-вправо
            float movement = Mathf.Sin(Time.time * Speed) * Distance;
            transform.position = new Vector3(startPos.x + movement, startPos.y, startPos.z);
        }
        
    }
}
