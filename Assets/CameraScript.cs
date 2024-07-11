using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject MyBirdGameObject;
    public GameObject MyCameraGameObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MyCameraGameObject.transform.position = new Vector3(MyBirdGameObject.transform.position.x + 1, 0, MyCameraGameObject.transform.position.z);
    }
}
