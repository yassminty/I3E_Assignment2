using UnityEngine;
using TMPro;

public class PlayerBehaviour : MonoBehaviour
{
    public int maxHealth = 100; //players starting health
    int currentScore = 0; //players score at the moment
    bool canInteract = false;
    DoorBehaviour currentDoor = null;
    CollectibleBehaviour currentHeart = null;

    public GameObject gameOverScreen; //game over screen if player dies

    //make sure that the player can interact with the objects and not mess this up PLEASE T-T
    void OnInteract()
    {
        if (canInteract)
        {
            if (currentHeart != null)
            {
                Debug.Log("please get the heart");
                //currentHeart.Collect(this);
            }

            else if (currentDoor != null)
            {
                Debug.Log("open sesame");
                currentDoor.Interact();
            }
        }
    }

    // increase score of player wehn they interact with the collectible i set up for them
    public void ChangeScore(int amount)
    {
        currentScore += amount;
    }


    // if player touches/presses enter on the object the object will be interacted ah if im not wrong...
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);

        // if object is the collectible, the player will be able to collect them and interact with them
        if (other.CompareTag("Heart"))
        {
            canInteract = true;
            currentHeart = other.GetComponent<CollectibleBehaviour>();
        }

        // if object is the door, the player will be able interact with it
        else if (other.CompareTag("Door"))
        {
            canInteract = true;
            currentDoor = other.GetComponent<DoorBehaviour>();
        }

        //if payer hits death object, they die and will do to game over screen
        else if (other.CompareTag("Death"))
        {
            Die();
        }
    }

    //when player hit collider of items [door/collectible]
    void OnTriggerExit(Collider other)
    {
        // see if player is nearby the thing , they will interact ah
        if (currentHeart != null)
        {
            // If the object that exited the trigger is the same as the current coin
            if (other.gameObject == currentHeart.gameObject)
            {
                canInteract = false; //stop making the player ointeract with them
                currentHeart = null;
            }
        }
    }

    void Die()
    {
        gameOverScreen.SetActive(true); //activate game over screen
        Application.Quit();
        Debug.Log("game wuit");
    }    


}
