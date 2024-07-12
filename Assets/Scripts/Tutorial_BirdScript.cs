using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

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

public class Tutorial_BirdScript : MonoBehaviour
{
    //Declare variable of type GameObject named MyBirdGameObject
    //public GameObject MyBirdGameObject;    //[STEP 2]

    //Declare variable of type Rigidbody named MyBirdRigidbody
    //public Rigidbody MyBirdRigidbody;    //[STEP 4]

    //Declare variables of type Vector3 named MyCurrentBirdSpeed, MyBirdSpeedToUse, MyBirdJumpForce, MyZeroSpeed
    //public Vector3 MyCurrentBirdSpeed;    //[STEP 2]
    //public Vector3 MyBirdSpeedToUse;
    //public Vector3 MyBirdJumpForce;    //[STEP 4]
    //public Vector3 MyZeroSpeed;    //[STEP 4]

    //Declare variable of type ForceMode named MyBirdForceMode
    //public ForceMode MyBirdForceMode;    //[STEP 4]

    //Declare variables of type AudioSource name MySwooshSound, MyPointSound, MyHitSound
    //public AudioSource MySwooshSound;   //[STEP 5]
    //public AudioSource MyPointSound;   //[STEP 7]
    //public AudioSource MyHitSound;   //[STEP 6]

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Call Translate function to move the MyBirdGameObject by MyCurrentBirdSpeed every second
        //MyBirdGameObject.transform.Translate(MyCurrentBirdSpeed * Time.deltaTime);    //[STEP 2]

        //If statement to check if the left mouse button was clicked on this update
        //if (Input.GetMouseButtonDown(0))    //[STEP 4]
        //{
            //Assign MyCurrentBirdSpeed value to MyBirdSpeedToUse value
            //MyCurrentBirdSpeed = MyBirdSpeedToUse;

            //Call MyBirdRigidbody variable that stores the reference to the Rigidbody component
            //Set useGravity variable to true
            //MyBirdRigidbody.useGravity = true;    //[STEP 4]

            //Play MySwooshSound audio
            //MySwooshSound.Play();   //[STEP 5]

            //Call MyBirdRigidbody variable that stores the reference to the Rigidbody component
            //Set velocity variable to MyZeroSpeed value
            //MyBirdRigidbody.velocity = MyZeroSpeed;    //[STEP 4]

            //Call MyBirdRigidbody variable that stores the reference to the Rigidbody component
            //Call AddForce and pass in MyBirdJumpForce as the 1st parameter, and MyBirdForceMode as the 2nd parameter
            //MyBirdRigidbody.AddForce(MyBirdJumpForce, MyBirdForceMode);
        //}
    }

    //OnCollisionEnter is called when the collider of the game object that this script is attached to intersects with another collider
    //private void OnCollisionEnter(Collision collision)   //[STEP 6]
    //{
        //Call StartCoroutine function and pass in the EndGameCoroutine function as a parameter
        //StartCoroutine(EndGameCoroutine());   //[STEP 9]

        //SceneManager.LoadScene("Tutorial_FinalScene");   //[STEP 8]

        //Assign MyCurrentBirdSpeed value to MyZeroSpeed value
        //MyCurrentBirdSpeed = MyZeroSpeed;

        //Play MyHitSound audio
        //MyHitSound.Play();   //[STEP 6]
    //}

    //OnTriggerEnter is called when the trigger collider of the game object -
    //- that this script is attached to intersects with another trigger collide
    //private void OnTriggerEnter(Collider other)   //[STEP 7]
    //{
        //Play MyPointSound audio
        //MyPointSound.Play();   //[STEP 7]
    //}

    //Declare a coroutine named EnGameCoroutine
    //Coroutines are like regular functions except that they allow you to wait for some amount of time -
    //- executing the code inside the coroutine code block
    //IEnumerator EndGameCoroutine()   //[STEP 9]
    //{
        //wait 0.5 seconds
        //yield return new WaitForSeconds(0.5f);   //[STEP 9]

        //Call SceneManager class and call LoadScene function and pass a string of the scene name you wish to load
        //This basically reloads your scene, reseting everything back to how it was at the start of the scene
        //SceneManager.LoadScene("Tutorial_FinalScene");   //[STEP 9]
    //}
}
