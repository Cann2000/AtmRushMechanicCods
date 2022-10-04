using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float FollowSpeed;
    public Vector3 offset;

    [SerializeField] Transform MainCharacter;


    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(MainCharacter.position.x, 75, MainCharacter.position.z), FollowSpeed) + offset;
    }

}
