using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Player
    private GameObject player;
    public float moveSpeed;

    //Mouse
    private Vector2 mousePosition;

    void Start()
    {
        //Assign
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        player.transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("dentro");
    }
}
