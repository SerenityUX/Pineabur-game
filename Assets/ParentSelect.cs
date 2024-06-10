using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.IO;

public class ParentSelect : MonoBehaviour
{
    public GameObject selectIndicator;
    public GameObject fatherSelector;
    public GameObject motherSelector;
    public TextMeshPro selectionText;
    public TextMeshPro correctPairing;
    public TextMeshPro failedPairing;
    public AudioSource clickSound; // Add this in the inspector
    public TextMeshPro babyNameText; // Assign a TMP Text element for the baby's name
    public TextMeshPro qualitiesText; // Assign a TMP Text element for the baby's qualities
    public GameObject plane; // Add this to reference the plane in the inspector

    private int fatherCounter = 2;
    private int motherCounter = 2;
    private float moveDistance = 2.0f;
    private float moveDuration = 0.15f;
    private bool isMoving = false;
    private bool isFatherActive = true;
    private int attempts = 0; // Track the number of attempts
    private bool showResult = false; // To manage the enter key after showing result
    private Vector3 initialPosition = new Vector3(6, 3.38f, -8.68f); // Initial position for selectors
    private List<BabyData.Baby> babiesBornToday;

    private List<string> fathers = new List<string> { "franklin", "seb", "dom", "dylan", "tyler", "steve" };
    private List<string> mothers = new List<string> { "nancy", "aadhya", "emma", "scarlett", "sabrina", "jane" };

    void Start()
    {
        babiesBornToday = BabyData.GetBabiesBornOnDay(SceneData.Day);
        foreach (var baby in babiesBornToday)
        {
            Debug.Log("Baby Name: " + baby.Name);
        }

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

        // Initialize the baby name and qualities
        if (babiesBornToday.Count > 0)
        {
            UpdateBabyInfo(babiesBornToday[0]);
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

        bool isCorrectPairing = false;
        BabyData.Baby matchedBaby = null;

        foreach (var baby in babiesBornToday)
        {
            if (fathers[fatherCounter] == baby.Father && mothers[motherCounter] == baby.Mother)
            {
                isCorrectPairing = true;
                matchedBaby = baby;
                break;
            }
        }

        if (isCorrectPairing)
        {
            if (correctPairing != null)
            {
                motherSelector.SetActive(false);
                selectionText.gameObject.SetActive(false);
                selectIndicator.SetActive(false);
                correctPairing.gameObject.SetActive(true);
            }

            // Update baby info if the pairing is correct
            if (matchedBaby != null)
            {
                UpdateBabyInfo(matchedBaby);
            }
        }
        else
        {
            if (failedPairing != null)
            {
                motherSelector.SetActive(false);
                selectionText.gameObject.SetActive(false);
                selectIndicator.SetActive(false);

                SceneData.Deaths = SceneData.Deaths + 1;

                if (SceneData.Deaths == 14)
                {
                    SceneManager.LoadScene("Lose");
                }

                failedPairing.gameObject.SetActive(true);
            }
        }

        showResult = true; // Set showResult to true to wait for Enter key press
    }

    void HandleResultAndRestart()
    {
        showResult = false;
        attempts++;

        if (attempts < babiesBornToday.Count)
        {
            ResetSelectors();

            // Update baby info to the next baby
            if (attempts < babiesBornToday.Count)
            {
                UpdateBabyInfo(babiesBornToday[attempts]);
            }
        }
        else
        {
            if (SceneData.Day != 6)
            {
                SceneData.Day = SceneData.Day + 1;
                SceneData.ElapsedTime = 0f;
                SceneManager.LoadScene("Train");
            }
            else
            {
                SceneManager.LoadScene("Win");
            }
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

    void UpdateBabyInfo(BabyData.Baby baby)
    {
        if (babyNameText != null)
        {
            babyNameText.text = baby.Name;
        }

        if (qualitiesText != null)
        {
            qualitiesText.text = string.Join("\n", baby.Qualities);
        }

        // Load and set the texture for the plane using the native resource loader
        if (plane != null)
        {
            // Load the texture from the Resources folder
            string resourcePath = "people/" + baby.Name;
            Texture2D texture = Resources.Load<Texture2D>(resourcePath);

            if (texture != null)
            {
                plane.GetComponent<Renderer>().material.mainTexture = texture;
            }
            else
            {
                Debug.LogWarning("Image not found in Resources folder: " + resourcePath);
            }
        }
    }
}
