using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D playerRigidbody;
    private Vector2 moveDirection = Vector2.zero;
    private float moveSpeed;

    public TextMeshProUGUI ScoreText;
    private int Newscore;
    private int currentScore;


    private void Awake()
    {
        playerRigidbody = this.GetComponent<Rigidbody2D>();
        Actions.MoveEvent += UpdateMoveVector;
        moveSpeed = 3f;
        Newscore = 0;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        HandlePlayerMovement();

        if (Newscore != currentScore)
        {
            currentScore = Newscore;
            ScoreText.text = "Score: " + currentScore;
        }
    }

    private void UpdateMoveVector(Vector2 InputVector)
    {
        moveDirection = InputVector;

    }

    public void HandlePlayerMovement() 
    {      
        playerRigidbody.MovePosition(playerRigidbody.position + moveDirection * Time.fixedDeltaTime * moveSpeed); 
    }

    private void OnDisable()
    {
        //Actions.MoveEvent -= UpdateMoveVector; 
    }

    void OnCollisionEnter2D(Collision2D collision)
    {        
        if (collision.gameObject.CompareTag("PickUp"))
        {
            collision.gameObject.SetActive(false);
            if(Newscore < 99999 && currentScore < 99999)
            Newscore++; 
        }
    }

    public void resetScore() 
    {
        Debug.Log("Reset"); 
        Newscore = 0;
    }

}
