using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
 {
 
     Vector3 pos;                                // For movement
    public float speed = 1.0f;                         // Speed of movement
 
     void Start()
     {
         pos = transform.position;          // Take the initial position
     }
 
     void Update()
     {
         if (Input.GetKeyDown(KeyCode.A) && transform.position == pos)
         {        // Left
             pos+= Vector3.left;
         }
         if (Input.GetKeyDown(KeyCode.D) && transform.position == pos)
         {        // Right
             pos+= Vector3.right;
         }
         if (Input.GetKeyDown(KeyCode.W) && transform.position == pos)
         {        // Up
             pos += Vector3.forward;
         }
         if (Input.GetKeyDown(KeyCode.S) && transform.position == pos)
         {        // Down
             pos += Vector3.back;
             
         }
         transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed);    // Move there
     }
 
 }