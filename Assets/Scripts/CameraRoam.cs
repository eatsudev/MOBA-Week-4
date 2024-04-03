using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRoam : MonoBehaviour
{
    public float camSpeed = 20;
    public float screenSizeThickness = 10;

    void Update()
    {
        Vector3 pos = transform.position;

        //up
        if(Input.mousePosition.y >= Screen.height - screenSizeThickness)
        {
            //pos.x -= camSpeed * Time.deltaTime;

            pos.z += camSpeed * Time.deltaTime; 
        }

        //down
        if(Input.mousePosition.y <= screenSizeThickness)
        {
            //pos.x += camSpeed * Time.deltaTime;

            pos.z -= camSpeed * Time.deltaTime;
        }

        //right
        if (Input.mousePosition.x >= Screen.height - screenSizeThickness)
        {
            //pos.z += camSpeed * Time.deltaTime;

            pos.x += camSpeed * Time.deltaTime;
        }

        //left
        if (Input.mousePosition.x <= screenSizeThickness)
        {
            //pos.z -= camSpeed * Time.deltaTime;

            pos.x -= camSpeed * Time.deltaTime;
        }

        transform.position = pos;
    }
}
