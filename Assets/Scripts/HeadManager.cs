using UnityEngine;
using UnityEngine.AI;

public class HeadManager : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject prefab;
    public Transform tail;

    public float tickFrequency = 100;
    public float tick = 0;

    public Transform apple;
    public NavMeshAgent nav;


    private void Update()
    {
        tick += Time.deltaTime;
        if (tick >= tickFrequency)
        {
            AddSegment();
            tick = 0;
        }

        nav.SetDestination(apple.position);
    }


    private void AddSegment()
    {
        GameObject segment = Instantiate(prefab, tail.position, Quaternion.identity);
        HeadFollower comp = segment.GetComponent<HeadFollower>();
        comp.head = tail;
        tail = segment.transform;
    }
}
