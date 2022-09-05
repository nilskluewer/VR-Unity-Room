using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    float speed = 50.0f;
    // Update is called once per frame
    void Update()
    {
         transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }
}
