using UnityEngine;

public class SimpleCameraController : MonoBehaviour
{
    public Transform Target; // ���� ��� ����������
    public Vector3 Offset = new Vector3(0, 2, -5); // �������� �� ����
    public float FollowSpeed = 2f; // �������� ����������
    public float ZoomSpeed = 2f; // �������� ����

    private Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
    }

    void LateUpdate()
    {
        if (Target == null) return;

        // ������ ������� �� �����
        Vector3 targetPosition = Target.position + Offset;
        transform.position = Vector3.Lerp(transform.position, targetPosition, FollowSpeed * Time.deltaTime);
        transform.LookAt(Target);

        // ��� ������� ����
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        cam.fieldOfView = Mathf.Clamp(cam.fieldOfView - scroll * ZoomSpeed, 20f, 80f);
    }
}