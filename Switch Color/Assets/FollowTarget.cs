using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour {

    public Transform target;

    private void Update()
    {
        if(target.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x,target.position.y,transform.position.z);
        }
    }

}
