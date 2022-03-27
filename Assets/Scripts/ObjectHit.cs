using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    MeshRenderer renderer; 
    private void OnCollisionEnter(Collision other) 
    {
        renderer = GetComponent<MeshRenderer>();
        if (other.gameObject.tag == "Player")
        {
            renderer.material.color = Color.red;
            gameObject.tag = "Hit";
        }
       
    }
}
