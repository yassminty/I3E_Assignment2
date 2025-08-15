using UnityEngine;

// making door move 
public class DoorBehaviour : MonoBehaviour
{
    public int requiredCollectibles = 5;
    public void Interact()
    {
        if (CollectibleBehaviour.collectedHearts >= requiredCollectibles)
        {
            Vector3 doorRotation = transform.eulerAngles;
            doorRotation.y += 90f; //will rotate door 90 degrees
            transform.eulerAngles = doorRotation; //is to apply the rotation
        }

        else
        {
            Debug.Log("you suck bro");
        }
    }
}
