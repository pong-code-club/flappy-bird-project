using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    //Declare variable of type GameObject named MyBirdGameObject
    public GameObject MyBirdGameObject;
    //Declare variable of type GameObject named MyPipeGameObject
    public GameObject MyPipeGameObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //If statement to check MyBirdGameObject is more than 7.5 units to the right of MyPipeGameObject
        if (MyBirdGameObject.transform.position.x - MyPipeGameObject.transform.position.x > 7.5)
        {
            //Declare a variable of type Vector3 named myCameraPositionToUse
            Vector3 myPositionToMoveBy;
            //Assign myPositionToMoveBy a new Vector3 that passes in 3 parameter values for x, y, and z values
            myPositionToMoveBy = new Vector3(15, 0, 0);

            //Add myPositionToMoveBy to MyPipeGameObject's transform component's position
            MyPipeGameObject.transform.position += myPositionToMoveBy;

            //Declare a variable of type float named randomPipePositionY;
            float myRandomPipePositionY;
            //Assign myRandomPipePositionY a random value between -2 and 2 using the Range function that exist on the Random Unity class
            myRandomPipePositionY = Random.Range(-2.0f, 2.0f);

            //Declare a variable of type float named myPipePositionX;
            float myPipePositionX;
            //Assign myPipePositionX to MyPipeGameObject's transform component's position's x value
            myPipePositionX = MyPipeGameObject.transform.position.x;

            //Declare a variable of type float named myPipePositionZ and -
            //- Assign myPipePositionZ to MyPipeGameObject's transform component's position's z value on the same line
            float myPipePositionZ = MyPipeGameObject.transform.position.z;

            //Assign MyPipeGameObject's transform component's position to a new Vector3 using -
            //- myPipePositionX as the first parameter -
            //- myRandomPipePositionY as the 2nd parameter -
            //- and myPipePositionZ as the 3rd parameter
            MyPipeGameObject.transform.position = new Vector3(myPipePositionX, myRandomPipePositionY, myPipePositionZ);
        }
    }
}
