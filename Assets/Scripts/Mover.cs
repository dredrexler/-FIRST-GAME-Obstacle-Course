using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();

    }

    // Update is called once per frame
    void Update()
    {
        Movement();

    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move your player with arrow keys or WASD");
        Debug.Log("Do not hit the walls");

    }

    void Movement()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue,0,zValue);
    }
}
