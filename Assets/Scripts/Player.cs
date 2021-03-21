
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
    public Vector3 mPosition;

    public Vector3 mCamPosition;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            mPosition = Input.mousePosition;
            mCamPosition = Camera.main.ScreenToWorldPoint(mPosition);
            this.transform.position = mCamPosition;
        }
    }
}