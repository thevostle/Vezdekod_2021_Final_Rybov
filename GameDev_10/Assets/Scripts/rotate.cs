using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    float x;
    void Update()
    {
        x += Time.deltaTime * 10;
        transform.rotation = Quaternion.Euler(0, x, 0);
    }
}
