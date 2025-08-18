using UnityEngine;
using TMPro;

public class NPCTalk : MonoBehaviour
{
    public GameObject IntroTalk; // UI stuff
    public TextMeshProUGUI introText; // intro text message
    // public TextMeshProUGUI ringText; // ring text message
    // public TextMeshProUGUI thanksText; // thanks text message


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            IntroTalk.SetActive(true); // show dialogue
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            IntroTalk.SetActive(false); // hide dialogue
        }
    }
}