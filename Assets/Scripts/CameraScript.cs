using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    //Declare variable of type GameObject named MyBirdGameObject
    public GameObject MyBirdGameObject;

    //Declare variable of type GameObject named MyCameraGameObject
    public GameObject MyCameraGameObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Declare a variable of type float named cameraPositionX
        //Assign myCameraPositionX value to MyBirdGameObject's transform component's position's x position
        float myCameraPositionX = MyBirdGameObject.transform.position.x;

        //Declare a variable of type float named cameraPositionZ
        //Assign myCameraPositionZ value to MyBirdGameObject's transform component's position's z position
        float myCameraPositionZ = MyCameraGameObject.transform.position.z;

        //Declare a variable of type Vector3 named myCameraPositionToUse
        Vector3 myCameraPositionToUse;
        //Assign myCameraPositionToUse a new Vector3 that passes in 3 parameter values for x, y, and z values
        myCameraPositionToUse = new Vector3(myCameraPositionX, 0, myCameraPositionZ);

        //Assign MyCameraGameObject's transform component's position to myCameraPositionToUse
        MyCameraGameObject.transform.position = new Vector3(myCameraPositionX, 0, myCameraPositionZ);
    }
}
