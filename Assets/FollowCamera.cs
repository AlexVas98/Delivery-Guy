using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    //this things potition (camera) should be the same as the cars potition
    [SerializeField] GameObject thingToFollow;
    void Update()
    {
        transform.position = thingToFollow.transform.position + new Vector3 (0,0,-10);
    }
}
