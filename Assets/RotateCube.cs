using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    private GameObject cube;

    void Start()
    {
        cube = this.gameObject;
    }

    void Update()
    {
        cube.transform.Rotate(new Vector3(45, 45, 45) * Time.deltaTime);
    }
}
