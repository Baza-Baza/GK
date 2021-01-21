using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    /*public Transform target;
    public float smoothspeed = 5f;
   public Vector3 offset;*/
    GameObject player;
    Vector3 offset;

    /*public Transform target;
    Vector3 startDis,MoveVec;*/


    private void Start()
    {
        player = GameObject.Find("Player");
        offset = new Vector3(-11f, 8.65f, -0.14f);
    }
    void Update()
    {
        transform.position = player.transform.position + offset;

        
    }
}
