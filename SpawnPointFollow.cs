using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointFollow : MonoBehaviour
{
    public float FollowSpeed;
    public Vector3 offset;

    public Transform MainCharacter;

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, MainCharacter.position, FollowSpeed) + offset;
    }
}
