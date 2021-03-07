using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isEnd = false;

    private void Update()
    {
        if (!isEnd) Cursor.lockState = CursorLockMode.Locked;
        else Cursor.lockState = CursorLockMode.None;
    }
}
