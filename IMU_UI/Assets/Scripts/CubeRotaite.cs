using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotaite : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotationSped = 50f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, rotationSped * Time.deltaTime);
    }
}
