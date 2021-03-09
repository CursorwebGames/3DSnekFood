using UnityEngine;

public class HeadSpawner : MonoBehaviour
{
    public Transform apple;
    public float minDistance;

    public Vector3 offset;


    private void Start()
    {
        do
        {
            Vector3 pos = offset + new Vector3(Random.Range(-28, 28), 0, Random.Range(-28, 28));
            transform.position = pos;
        } while (Vector3.Distance(transform.position, apple.position) < minDistance);
    }
}
