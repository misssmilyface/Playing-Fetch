using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class MoveForwardX : MonoBehaviour
{
    public float speed;
    //private float time = 2;

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
