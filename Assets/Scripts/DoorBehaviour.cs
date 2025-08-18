using UnityEngine;
using System.Collections;

// making door move 
// see if the player has collected enough items to open the door and rotates it when they have.
public class DoorBehaviour : MonoBehaviour
{
    public int requiredCollectibles = 5;
    private bool isOpen = false;

    void Start()
    {
        StartCoroutine(CheckCollectiblesAndOpen());
    }

    IEnumerator CheckCollectiblesAndOpen()
    {
        while (!isOpen)
        {
            if (CollectibleBehaviour.collectedHearts >= requiredCollectibles)
            {
                OpenDoor();
                isOpen = true;
            }
            yield return new WaitForSeconds(0.5f); // Check every 0.5 seconds
        }
    }

    void OpenDoor()
    {
        Vector3 doorRotation = transform.eulerAngles;
        doorRotation.y += 90f; // Rotate door 90 degrees
        transform.eulerAngles = doorRotation;
        Debug.Log("Door unlocked and opened by AI!");
    }
}