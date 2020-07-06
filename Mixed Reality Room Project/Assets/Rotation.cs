using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public GameObject furniture;
    public int n = 0;
    public float y;
    public float rotationSpeed;

    void Start()
    {
        y = 0.0f;
        rotationSpeed = 5.0f;
    }

    void Update()
    {
        //if (rotationActivated == true)
        //{
        //    y = y + sign * rotationSpeed;
        //}

         
        furniture.transform.localRotation = Quaternion.Euler(0, y, 0);
    }


    public void leftClick()
    {
        y += rotationSpeed;
    }

    public void rightClick()
    {
        y -= rotationSpeed;
    }
}