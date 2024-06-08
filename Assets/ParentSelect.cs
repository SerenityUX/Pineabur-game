using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; // Add this to handle scene changes

public class ParentSelect : MonoBehaviour
{
    public GameObject selectIndicator;
    public GameObject fatherSelector;
    public GameObject motherSelector;
    public TextMeshPro selectionText;
    public TextMeshPro correctPairing;
    public TextMeshPro failedPairing;
    public AudioSource clickSound; // Add this in the inspector

    private int fatherCounter = 2;
    private int motherCounter = 2;
    private float moveDistance = 2.0f;
    private float moveDuration = 0.15f;
    private bool isMoving = false;
    private bool isFatherActive = true;
    private int attempts = 0; // Track the number of attempts
    private bool showResult = false; // To manage the enter key after showing result
    private Vector3 initialPosition = new Vector3(6, 3.38f, -8.68f); // Initial position for selectors

    void Start()
    {
        if (motherSelector != null)
        {
            motherSelector.SetActive(false);
        }
        if (correctPairing != null)
        {
            correctPairing.gameObject.SetActive(false);
        }
        if (failedPairing != null)
        {
            failedPairing.gameObject.SetActive(false);
        }
    }

    void Update()
    {
        if (!isMoving && !showResult)
        {
            if (isFatherActive)
            {
                if (Input.GetKeyDown(KeyCode.D))
                {
                    PlayClickSound();
                    StartCoroutine(MoveSelector(Vector3.left, fatherSelector, true));
                }
                else if (Input.GetKeyDown(KeyCode.A))
                {
                    PlayClickSound();
                    StartCoroutine(MoveSelector(Vector3.right, fatherSelector, true));
                }
                else if (Input.GetKeyDown(KeyCode.Return))
                {
                    PlayClickSound();
                    ActivateMotherSelector();
                }
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.D))
                {
                    PlayClickSound();
                    StartCoroutine(MoveSelector(Vector3.left, motherSelector, false));
                }
                else if (Input.GetKeyDown(KeyCode.A))
                {
                    PlayClickSound();
                    StartCoroutine(MoveSelector(Vector3.right, motherSelector, false));
                }
                else if (Input.GetKeyDown(KeyCode.Return))
                {
                    PlayClickSound();
                    FinalizeSelection();
                }
            }
        }
        else if (showResult && Input.GetKeyDown(KeyCode.Return))
        {
            HandleResultAndRestart();
        }
    }

    void ActivateMotherSelector()
    {
        if (fatherSelector != null)
        {
            fatherSelector.SetActive(false);
        }
        if (motherSelector != null)
        {
            motherSelector.SetActive(true);
        }
        isFatherActive = false;

        if (selectionText != null)
        {
            selectionText.text = "Who's the mother?";
        }

        Debug.Log("Father Counter saved: " + fatherCounter);
    }

    void FinalizeSelection()
    {
        Debug.Log("Mother Counter: " + motherCounter);

        if (fatherCounter == 0 && motherCounter == 0)
        {
            if (correctPairing != null)
            {
                motherSelector.SetActive(false);
                selectionText.gameObject.SetActive(false);
                selectIndicator.SetActive(false);
                correctPairing.gameObject.SetActive(true);
            }
        }
        else
        {
            if (failedPairing != null)
            {
                motherSelector.SetActive(false);
                selectionText.gameObject.SetActive(false);
                selectIndicator.SetActive(false);
                failedPairing.gameObject.SetActive(true);
            }
        }

        showResult = true; // Set showResult to true to wait for Enter key press
    }

    void HandleResultAndRestart()
    {
        showResult = false;
        attempts++;

        if (attempts < 3)
        {
            ResetSelectors();
        }
        else
        {
            SceneManager.LoadScene("Train");
        }
    }

    void ResetSelectors()
    {
        if (correctPairing != null)
        {
            correctPairing.gameObject.SetActive(false);
        }
        if (failedPairing != null)
        {
            failedPairing.gameObject.SetActive(false);
        }
        if (selectionText != null)
        {
            selectionText.gameObject.SetActive(true);
            selectionText.text = "Who's the father?";
        }
        if (selectIndicator != null)
        {
            selectIndicator.SetActive(true);
        }
        if (fatherSelector != null)
        {
            fatherSelector.transform.position = initialPosition; // Reset to initial position
            fatherSelector.SetActive(true);
        }
        if (motherSelector != null)
        {
            motherSelector.transform.position = initialPosition; // Reset to initial position
            motherSelector.SetActive(false);
        }

        fatherCounter = 2;
        motherCounter = 2;
        isFatherActive = true;
        isMoving = false;
    }

    IEnumerator MoveSelector(Vector3 direction, GameObject selector, bool isFather)
    {
        isMoving = true;

        Vector3 startPosition = selector.transform.position;
        Vector3 endPosition = startPosition + direction * moveDistance;
        float elapsedTime = 0f;

        while (elapsedTime < moveDuration)
        {
            selector.transform.position = Vector3.Lerp(startPosition, endPosition, elapsedTime / moveDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        selector.transform.position = endPosition;

        if (isFather)
        {
            if (direction == Vector3.left)
            {
                fatherCounter++;
            }
            else if (direction == Vector3.right)
            {
                fatherCounter--;
            }
            Debug.Log("Father Counter: " + fatherCounter);
        }
        else
        {
            if (direction == Vector3.left)
            {
                motherCounter++;
            }
            else if (direction == Vector3.right)
            {
                motherCounter--;
            }
            Debug.Log("Mother Counter: " + motherCounter);
        }

        isMoving = false;
    }

    void PlayClickSound()
    {
        if (clickSound != null)
        {
            clickSound.Play();
        }
    }
}
