using UnityEngine;
using TMPro;

public class NPCDialogue : MonoBehaviour
{
    public GameObject dialogueUI; // Assign a UI panel in Inspector
    public TextMeshProUGUI dialogueText; // Assign your dialogue text object in Inspector
    public string[] dialogues; // Add your dialogues in Inspector
    private int currentDialogue = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            dialogueUI.SetActive(true);
            ShowDialogue();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            dialogueUI.SetActive(false);
            currentDialogue = 0; // reset dialogue if needed
        }
    }

    public void NextDialogue()
    {
        currentDialogue++;
        if (currentDialogue < dialogues.Length)
        {
            ShowDialogue();
        }
        else
        {
            dialogueUI.SetActive(false); // hide UI when finished
            currentDialogue = 0;
        }
    }

    void ShowDialogue()
    {
        dialogueText.text = dialogues[currentDialogue];
    }
}
