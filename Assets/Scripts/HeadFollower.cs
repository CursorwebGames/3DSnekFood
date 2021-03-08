using UnityEngine;

public class HeadFollower : MonoBehaviour
{
    public float speed = 200;
    public Transform head;

    void Update()
    {
        Vector3 direction = head.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.up);
        transform.localRotation *= rotation;
        transform.position += direction * speed * Time.deltaTime;
    }
}
