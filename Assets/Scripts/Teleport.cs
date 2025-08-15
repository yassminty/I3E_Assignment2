using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform player, destination;
    public GameObject playerGameObject;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerGameObject.SetActive(false);
            playerGameObject.transform.position = destination.position; //change destination to the other platform
            playerGameObject.SetActive(true);
        }
    }
}

// this script teleports the player to a designated destination when they enter the trigger collider.
