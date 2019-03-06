using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform transformToFollow;
    Vector3 tempPosition;

	
	void Start ()
    {
		
	}
	
	
	void Update ()
    {
        tempPosition.x = transformToFollow.position.x; //Car X
        tempPosition.y = transformToFollow.position.y; //Car Y
        tempPosition.z = transformToFollow.position.z; //Camera Z

        transform.position = tempPosition;
        
    }
}
