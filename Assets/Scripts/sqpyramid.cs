using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sqpyramid : MonoBehaviour
{
    [SerializeField] public float rotateSpeed;

    void update()
    {
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
    }
}
