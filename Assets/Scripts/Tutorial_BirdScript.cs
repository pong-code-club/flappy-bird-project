using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tutorial_BirdScript : MonoBehaviour
{
    public Rigidbody MyBirdRigidbody;
    public Vector3 MyBirdSpeed;

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
        transform.Translate(MyBirdSpeed * Time.deltaTime);

        if (Input.GetMouseButtonDown(0))
        {
            MyBirdSpeed = new Vector3(2, 0, 0);
            MyBirdRigidbody.useGravity = true;

            MySwooshSound.Play();

            MyBirdRigidbody.velocity = new Vector3(0, 0, 0);
            MyBirdRigidbody.AddForce(new Vector3(0, 12.8f, 0), ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        StartCoroutine(EndGameCoroutine());
        MyBirdSpeed = new Vector3(0, 0, 0);

        MyHitSound.Play();
    }

    private void OnTriggerEnter(Collider other)
    {
        MyPointSound.Play();
    }

    IEnumerator EndGameCoroutine()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("FinalScene");
    }
}
