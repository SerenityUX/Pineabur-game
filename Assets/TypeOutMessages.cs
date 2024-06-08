using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement; // Make sure to include this for scene management

public class TypingEffect : MonoBehaviour
{
    public TextMeshPro textMeshPro;
    public float typingSpeed = 0.05f;

    private string[] messages = {
        "It turned dark. You leave to your train car for the night...",
        "You wake up and hear baby screams in the passenger cart...",
        "You must now do your job and identify who the parents are.",
        "If you're successful, the baby will go live with its parents...",
        "If you fail, the baby will be thrown off the train."
    };

    private int currentMessageIndex = 0;
    private Coroutine typingCoroutine;

    private void Start()
    {
        StartTypingMessage();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (typingCoroutine != null)
            {
                StopCoroutine(typingCoroutine);
                textMeshPro.text = messages[currentMessageIndex]; // Fill out the rest of the message
                typingCoroutine = null;
            }
            else
            {
                if (currentMessageIndex < messages.Length - 1)
                {
                    currentMessageIndex++;
                    StartTypingMessage();
                }
                else
                {
                    SceneManager.LoadScene("ParentSelect"); // Change this to the actual scene name for parent selection
                }
            }
        }
    }

    private void StartTypingMessage()
    {
        textMeshPro.text = "";
        typingCoroutine = StartCoroutine(TypeMessage(messages[currentMessageIndex]));
    }

    private IEnumerator TypeMessage(string message)
    {
        foreach (char letter in message.ToCharArray())
        {
            textMeshPro.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
        typingCoroutine = null; // Typing is complete
    }
}
