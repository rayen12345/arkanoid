using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks1 : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {

        Destroy(gameObject);
        Debug.Log("you won");



    }

}
