using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdScript : MonoBehaviour
{
    //Declare variable of type GameObject named MyBirdGameObject
    public GameObject MyBirdGameObject;

    //Declare variable of type Rigidbody named MyBirdRigidbody
    public Rigidbody MyBirdRigidbody;

    //Declare variables of type Vector3 named MyCurrentBirdSpeed, MyBirdSpeedToUse, MyBirdJumpForce, MyZeroSpeed
    public Vector3 MyCurrentBirdSpeed;
    public Vector3 MyBirdSpeedToUse;
    public Vector3 MyBirdJumpForce;
    public Vector3 MyZeroSpeed;

    //Declare variable of type ForceMode named MyBirdForceMode
    public ForceMode MyBirdForceMode;

    //Declare variables of type AudioSource name MySwooshSound, MyPointSound, MyHitSound
    public AudioSource MySwooshSound;
    public AudioSource MyPointSound;
    public AudioSource MyHitSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Call Translate function to move the MyBirdGameObject by MyCurrentBirdSpeed every second
        MyBirdGameObject.transform.Translate(MyCurrentBirdSpeed * Time.deltaTime);

        //If statement to check if the left mouse button was clicked on this update
        if (Input.GetMouseButtonDown(0))
        {
            //Assign MyCurrentBirdSpeed value to MyBirdSpeedToUse value
            MyCurrentBirdSpeed = MyBirdSpeedToUse;

            //Call MyBirdRigidbody variable that stores the reference to the Rigidbody component
            //Set useGravity variable to true
            MyBirdRigidbody.useGravity = true;

            //Play MySwooshSound audio
            MySwooshSound.Play();

            //Call MyBirdRigidbody variable that stores the reference to the Rigidbody component
            //Set velocity variable to MyZeroSpeed value
            MyBirdRigidbody.velocity = MyZeroSpeed;

            //Call MyBirdRigidbody variable that stores the reference to the Rigidbody component
            //Call AddForce and pass in MyBirdJumpForce as the 1st parameter, and MyBirdForceMode as the 2nd parameter
            MyBirdRigidbody.AddForce(MyBirdJumpForce, MyBirdForceMode);
        }
    }

    //OnCollisionEnter is called when the collider of the game object that this script is attached to intersects with another collider
    private void OnCollisionEnter(Collision collision)
    {
        //Call StartCoroutine function and pass in the EndGameCoroutine function as a parameter
        StartCoroutine(EndGameCoroutine());

        //Assign MyCurrentBirdSpeed value to MyZeroSpeed value
        MyCurrentBirdSpeed = MyZeroSpeed;

        //Play MyHitSound audio
        MyHitSound.Play();
    }

    //OnTriggerEnter is called when the trigger collider of the game object -
    //- that this script is attached to intersects with another trigger collide
    private void OnTriggerEnter(Collider other)
    {
        //Play MyPointSound audio
        MyPointSound.Play();
    }

    //Declare a coroutine named EnGameCoroutine
    //Coroutines are like regular functions except that they allow you to wait for some amount of time -
    //- executing the code inside the coroutine code block
    IEnumerator EndGameCoroutine()
    {
        //wait 0.5 seconds
        yield return new WaitForSeconds(0.5f);

        //Call SceneManager class and call LoadScene function and pass a string of the scene name you wish to load
        //This basically reloads your scene, reseting everything back to how it was at the start of the scene
        SceneManager.LoadScene("FinalScene");
    }
}
