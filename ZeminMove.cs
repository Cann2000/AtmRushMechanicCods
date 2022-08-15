using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeminMove : MonoBehaviour
{
    public float ZeminSpeed;


    void Update()
    {
        transform.Translate(0, 0, -ZeminSpeed * Time.deltaTime);
    }
}
