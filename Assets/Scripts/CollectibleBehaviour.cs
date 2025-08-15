using UnityEngine;
using TMPro;


public class CollectibleBehaviour : MonoBehaviour
{
    private int heartValue = 0; //so amount cant be changed externally
    private int roseValue = 0;
    private int daisyValue = 0;
    public TextMeshProUGUI Score; //using tmpro for ui stuff
    public TextMeshProUGUI RoseScore;
    public TextMeshProUGUI DaisyScore;
    public GameObject endScreen;
    public static int collectedHearts = 0;
    public static int totalHearts = 5;

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Heart")
        {
            heartValue += 5; //increases score of player
            Score.text = "Score: " + heartValue.ToString(); //updates score for player after they interact with the items
            Debug.Log(heartValue); //just to write out in console if it works lol
            Destroy(other.gameObject); //collectible willbe destroyed after user is done interacting with it
        }

        else if (other.transform.tag == "Roses")
        {
            roseValue += 1; //increases score of player
            RoseScore.text = "Roses: " + roseValue.ToString() + "/13"; //updates score for player after they interact with the items
            Debug.Log(roseValue); //just to write out in console if it works lol
            Destroy(other.gameObject); //collectible willbe destroyed after user is done interacting with it
        }

        else if (other.transform.tag == "Daisies")
        {
            daisyValue += 1; //increases score of player
            DaisyScore.text = "Daisies: " + daisyValue.ToString() + "/10"; //updates score for player after they interact with the items
            Debug.Log(daisyValue); //just to write out in console if it works lol
            Destroy(other.gameObject); //collectible willbe destroyed after user is done interacting with it
        }

        //make collectible item counter go higher and will show end screen when collected every item
        else if (other.CompareTag("Player"))
        {
            collectedHearts++;

            if (collectedHearts >= totalHearts) //&& endScreen != null)
            {
                endScreen.SetActive(true); //opens congrats screen
                Debug.Log("everything collected already");
            }

            // Destroy(gameObject);
        }
    }    
}