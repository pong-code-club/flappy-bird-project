using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//STEP 1: Add bird and pipes objects
//STEP 2: Make bird fly straight
//STEP 3: Make pipes move position based on bird
//STEP 4: Add bird jump
//STEP 5: Add sound for bird jump
//STEP 6: OnCollisionEnter add sound for hitting objects
//STEP 7: OnTriggerEnter add sound for going through pipes
//STEP 8: LoadScene to restart game, introduce coroutines here
//STEP 9: Coroutines to delay scene reload
//STEP 10: Add Camera Follow
//STEP 11: Add art

public class Tutorial_CameraScript : MonoBehaviour
{
    //Declare variable of type GameObject named MyBirdGameObject
    //public GameObject MyBirdGameObject;    //[STEP 10]

    //Declare variable of type GameObject named MyCameraGameObject
    //public GameObject MyCameraGameObject;    //[STEP 10]

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Declare a variable of type float named cameraPositionX
        //Assign myCameraPositionX value to MyBirdGameObject's transform component's position's x position
        //float myCameraPositionX = MyBirdGameObject.transform.position.x;    //[STEP 10]

        //Declare a variable of type float named cameraPositionZ
        //Assign myCameraPositionZ value to MyBirdGameObject's transform component's position's z position
        //float myCameraPositionZ = MyCameraGameObject.transform.position.z;    //[STEP 10]

        //Declare a variable of type Vector3 named myCameraPositionToUse
        //Vector3 myCameraPositionToUse;    //[STEP 10]
        //Assign myCameraPositionToUse a new Vector3 that passes in 3 parameter values for x, y, and z values
        //myCameraPositionToUse = new Vector3(myCameraPositionX, 0, myCameraPositionZ);    //[STEP 10]

        //Assign MyCameraGameObject's transform component's position to myCameraPositionToUse
        //MyCameraGameObject.transform.position = myCameraPositionToUse;    //[STEP 10]
    }
}
