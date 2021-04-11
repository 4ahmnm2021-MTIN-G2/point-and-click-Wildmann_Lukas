
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
    public Vector3 mPosition;

    public Vector3 mCamPosition;

    public Vector3 playerPos;

    public float speed = 0.1f;

    void Start()
    {
        playerPos = this.transform.position;
    }
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            mPosition = Input.mousePosition;
            mCamPosition = Camera.main.ScreenToWorldPoint(mPosition);
            playerPos = new Vector3(mCamPosition.x, mCamPosition.y, this.transform.position.z);

        }
        
            
            this.transform.position = Vector3.MoveTowards(this.transform.position, playerPos, speed);
        
    }
}