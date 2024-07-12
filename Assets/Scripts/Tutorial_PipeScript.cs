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

public class Tutorial_PipeScript : MonoBehaviour
{
    //Declare variable of type GameObject named MyBirdGameObject
    //public GameObject MyBirdGameObject;    //[STEP 3]
    //Declare variable of type GameObject named MyPipeGameObject
    //public GameObject MyPipeGameObject;    //[STEP 3]
    //Declare variable of type Vector3 named MyPositionToMoveBy
    //public Vector3 MyPositionToMoveBy;    //[STEP 3]

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //If statement to check MyBirdGameObject is more than 7.5 units to the right of MyPipeGameObject
        //if (MyBirdGameObject.transform.position.x - MyPipeGameObject.transform.position.x > 7.5)    //[STEP 3]
        //{
            //Add MyPositionToMoveBy to MyPipeGameObject's transform component's position
            //MyPipeGameObject.transform.position += MyPositionToMoveBy;    //[STEP 3]

            //Declare a variable of type float named randomPipePositionY;
            //float myRandomPipePositionY;
            //Assign myRandomPipePositionY a random value between -2 and 2 using the Range function that exist on the Random Unity class
            //myRandomPipePositionY = Random.Range(-2.0f, 2.0f);

            //Declare a variable of type float named myPipePositionX;
            //float myPipePositionX;
            //Assign myPipePositionX to MyPipeGameObject's transform component's position's x value
            //myPipePositionX = MyPipeGameObject.transform.position.x;

            //Declare a variable of type float named myPipePositionZ and -
            //- Assign myPipePositionZ to MyPipeGameObject's transform component's position's z value on the same line
            //float myPipePositionZ = MyPipeGameObject.transform.position.z;

            //Assign MyPipeGameObject's transform component's position to a new Vector3 using -
            //- myPipePositionX as the first parameter -
            //- myRandomPipePositionY as the 2nd parameter -
            //- and myPipePositionZ as the 3rd parameter
            //MyPipeGameObject.transform.position = new Vector3(myPipePositionX, myRandomPipePositionY, myPipePositionZ);
        //}
    }
}
