using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonController : MonoBehaviour
{
    public GameObject MyCube;

    public void InstantiateMyCube()
    {
        Instantiate(MyCube, new Vector3(0, 2, 2), Quaternion.identity);
    }
}
