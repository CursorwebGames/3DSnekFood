using UnityEngine;

public class TreeSpawner : MonoBehaviour
{
    public GameObject prefab;
    public Vector3 offset;

    public float tick;
    public float maxTick;

    private void Update()
    {
        tick += Time.deltaTime;

        if (tick >= maxTick)
        {
            Destroy(gameObject);
            Instantiate(prefab, transform.position + offset, Quaternion.identity);
        }
    }
}
