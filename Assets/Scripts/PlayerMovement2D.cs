using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMovement2D : MonoBehaviour
{
    // Start is called before the first frame update

    public CharacterController2D controller;
    public Animator animator;

    public string playerName = "Bob";

    public int health;
    public Text healthText;

    public float runSpeed = 75f;
    public float sprintSpeed = 100f;

    float horizontalMove = 0f;
    public int coins;
    public Text coinsText;
    public AudioClip coinPickUp;

    bool jump = false;
    bool crouch = false;
    bool fireball = false;

    bool pickUpCoin = false;
    bool pickupChest = false;

    int neededExp = 100;
    public int Experience = 0;
    public Text rankText;
    bool pickUpExp = false;
    int Rank = 0;
    bool achievedMaxRank;
    int maxRank = 15;
    public bool canMove = true;

    public GameOver dead;
    public GameObject MainCamera;

    public Rigidbody2D rigid;

    public GameObject deathUI;

    RigidbodyConstraints2D pos;

    DeathManager dm;

    private void Awake()
    {
        dm = GameObject.FindObjectOfType<DeathManager>();
    }


    public enum Difficulty
    {
        EASY, MEDIUM, HARD
    }

    public string level;
    // Update is called once per frame
    void Update()                                                              
    {                                                                          
        coinsText.text = "" + coins;                                           
        healthText.text = "Health:" + health;                                  
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;            
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));                 
                                                                               
        if (Input.GetButtonDown("Jump"))                                       
            {                                                                  
                jump = true;                                                   
                animator.SetBool("IsJumping", true);                           
            }                                                                  
                                                                               
        if (Input.GetKey(KeyCode.LeftShift))                                   
            {                                                                  
                horizontalMove = Input.GetAxisRaw("Horizontal") * sprintSpeed; 
            }                                                                  
                                                                               
        if (canMove == true)                                                   
        {                                                                      
            // Move our character                                              
            controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
            jump = false;                                                      
        }                                                                      
                                                                               
        if (health <= 0)                                                       
        {
            rigid.constraints = RigidbodyConstraints2D.FreezePosition;
            this.GetComponent<SpriteRenderer>().enabled = false;
            deathUI.SetActive(true);
            dm.IncreaseDeaths();
            health = 100;
        }                                 
        
    }                                                                          
                                                                               
    public void OnLanding ()                                                   
    {                                                                          
        animator.SetBool("IsJumping", false);                                  
    }                                                                          
                                                                               
    void OnTriggerEnter2D(Collider2D collider)
    {        
        switch (collider.gameObject.tag)
        {
            case "Coin": PickUpCoin(); Destroy(collider.gameObject); break;
            case "Chest": PickUpChest(); Destroy(collider.gameObject); break;
            case "Exp": RankUp(); Destroy(collider.gameObject); break; 
        } 
    }

    void PickUpCoin() // Delete
    {
        coins++;
        //Debug.Log("Collided");
        pickUpCoin = true;
        Debug.Log(coins);
        AudioSource.PlayClipAtPoint(coinPickUp, transform.position);
    }

    void PickUpChest()  // Delete    
    {
        pickupChest = true;
        coins += 10;       
    }

    void RankUp() // Delete
    {
        if(Experience + 50 >= neededExp)
        {
            Rank++;
            rankText.text = "Rank " + Rank;
            Experience = 0;
            neededExp += 50;
            health += 10;
        }
        else
        {
            Experience += 50;
        }
    }

    public void Dif()
    {
        Difficulty difficulty = Difficulty.EASY;

        switch (difficulty)
        {
            case Difficulty.EASY: health = 150; break;
            case Difficulty.MEDIUM: health = 100; break;
            case Difficulty.HARD: health = 50; break;
            default: health = 150; break;
        }
    } 

    public void ResetCharacter()
    {
        health -= 3000;
    }

    public void RestartButton()
    {               
        SceneManager.LoadScene(level);       
    }

    

}
