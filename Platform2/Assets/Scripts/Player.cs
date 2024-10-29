using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Author: [ (Serrato, Denise), (Carey, Madison),  ]
 * Date Created: [10/29/2024]
 * Last Updated: [10/29/2024]
 * [This will handle the player movement.]
 */

public class Player : MonoBehaviour

{
    private Rigidbody rigidbody;
    public float jump;
    public float speed;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Player will move by adding force when either the A, D, left arrow, or right arrow are pressed.
    /// </summary>
    private void PlayerMoves()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody.MovePosition(transform.position + Vector3.left * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody.MovePosition(transform.position + Vector3.right * speed * Time.deltaTime);
        }
    }
}
