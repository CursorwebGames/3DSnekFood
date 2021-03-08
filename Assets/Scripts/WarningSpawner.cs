using UnityEngine;

public class WarningSpawner : MonoBehaviour
{
    public GameObject prefab;
    public Vector3 offset;

    public float tick = 0;
    public float maxTick = 0;

    private void Update()
    {
        tick += Time.deltaTime;

        if (tick >= maxTick)
        {
            tick = 0;
            Vector3 position = new Vector3(Random.Range(-28, 28), 0, Random.Range(-28, 28));
            Instantiate(prefab, position + offset, Quaternion.identity);
        }
    }
}
