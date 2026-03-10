using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator animator;

    GameObject gameManager;

    public int score;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0) && animator.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
        {
            animator.SetTrigger("triggerTeleport");
            playerTeleport();
        }
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("TeleportIn"))
        {
            this.transform.position = GameObject.FindWithTag("TPTarget").transform.position;
        }

    }
    private void playerTeleport()
    {
        GameObject crosshair = GameObject.FindWithTag("TPTarget");
        
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            Debug.Log("Player has collided with the ground");
            playerDeath();
        }
        else if (collision.CompareTag("Coin"))
        {
            Debug.Log("Player has collected a coin");
            score += collision.GetComponent<CoinLogic>().collectCoin();
        }
    }

    void playerDeath()
    {
        Debug.Log("Player has died");
        gameManager.GetComponent<GameManager>().gameOver(score);
        this.gameObject.SetActive(false);
    }
}
