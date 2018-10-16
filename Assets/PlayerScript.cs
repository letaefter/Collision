using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody2D rigidBody1;
    public float speed;

    // Use this for initialization
    void Start()
    {
        //rigidBody1.AddForce(new Vector2(0, 20f), ForceMode2D.Impulse);


    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("SampleScene"); //UnLoadScene också
        }
    }
    private void OnCollisionEnter2D(Collision2D coll) // = collision = coll
    {
        SceneManager.LoadScene("SampleScene");
    }

    // Update is called once per frame
    private void FixedUpdate() // om man har input saker i fixedupdate kan den tro 1 sekund är 50 inputs ifall det laggar och är 1fps t.ex.
        //den är alltid 50 Updates per sekund
    {
        if (Input.GetKey(KeyCode.D))
        {
            //rigidBody1.AddForce lägg till kraft
            //rigidBody1.AddRelativeForce lägg till relativ kraft
            //rigidBody.AddTorque rotering eller nåt
            //rigidBody1.MovePosition
            //rigidBody1.Velocity hastigheten
            //rigidBody.angularVelocity runt en cirkel
            rigidBody1.AddForce(new Vector2(speed, 0f));
        }
        if (Input.GetKey(KeyCode.A))
        {
            rigidBody1.AddForce(new Vector2(-speed, 0f));
        }
        if (Input.GetKey(KeyCode.W))
        {
            rigidBody1.AddForce(new Vector2(0f, speed));
        }
        if (Input.GetKey(KeyCode.S))
        {
            rigidBody1.AddForce(new Vector2(0f, -speed));
        }
    }
}
