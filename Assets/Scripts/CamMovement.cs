using System;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    public Transform player;

    public float xSens;
    public float ySens;
    public float maxY;

    private Quaternion camDefault;


    private void Start()
    {
        camDefault = transform.localRotation;
    }

    private void Update()
    {
        RotateY();
        RotateX();
    }

    private void RotateX()
    {
        float horiz = Input.GetAxis("Mouse X") * xSens * Time.deltaTime;
        Quaternion rotation = Quaternion.AngleAxis(horiz, Vector3.up);
        player.localRotation *= rotation;
    }

    private void RotateY()
    {
        float vert = Input.GetAxis("Mouse Y") * ySens * Time.deltaTime;
        Quaternion rotation = Quaternion.AngleAxis(vert, Vector3.left);
        Quaternion delta = transform.localRotation * rotation;
        if (Quaternion.Angle(camDefault, delta) < maxY) transform.localRotation = delta;
    }
}
