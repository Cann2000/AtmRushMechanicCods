using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceMove : MonoBehaviour
{
    public float PlaceSpeed;


    void Update()
    {
        transform.Translate(0, 0, -PlaceSpeed * Time.deltaTime);
    }
}
