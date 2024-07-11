using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public GameObject MyBirdGameObject;
    public GameObject MyPipeGameObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (MyBirdGameObject.transform.position.x - MyPipeGameObject.transform.position.x > 7.5)
        {
            gameObject.transform.position += new Vector3(15, 0, 0);
            gameObject.transform.position = new Vector3(MyPipeGameObject.transform.position.x, Random.Range(-2, 2), MyPipeGameObject.transform.position.z);
        }
    }
}
