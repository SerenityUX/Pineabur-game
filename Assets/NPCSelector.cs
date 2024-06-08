using UnityEngine;
using UnityEngine.SceneManagement;

public class NPCSelector : MonoBehaviour
{
    private Camera _mainCamera;
    private GameObject _highlightedNPC;
    private Material _originalMaterial;
    public Material glowMaterial; // Assign a material with glow and stroke effects

    void Start()
    {
        _mainCamera = Camera.main;
    }

    void Update()
    {
        HighlightNPC();
        CheckForInteraction();
    }

    void HighlightNPC()
    {
        Ray ray = _mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            GameObject hitObject = hit.collider.gameObject;

            if (hitObject.CompareTag("NPC"))
            {
                if (_highlightedNPC != hitObject)
                {
                    if (_highlightedNPC != null)
                    {
                        ResetNPC(); // Reset previously highlighted NPC
                    }

                    _highlightedNPC = hitObject;
                    _originalMaterial = _highlightedNPC.GetComponent<Renderer>().material;
                    _highlightedNPC.GetComponent<Renderer>().material = glowMaterial; // Apply glow material
                }
            }
            else
            {
                if (_highlightedNPC != null)
                {
                    ResetNPC(); // Reset if no NPC is under cursor
                }
            }
        }
        else
        {
            if (_highlightedNPC != null)
            {
                ResetNPC(); // Reset if no hit at all
            }
        }
    }

    void CheckForInteraction()
    {
        if (_highlightedNPC != null && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log(_highlightedNPC.name);
            SceneData.PreviousScene = SceneManager.GetActiveScene().name;
            SceneData.NPCName = _highlightedNPC.name; // Set the NPC's name
            SceneManager.LoadScene("NPCTalking");
        }
    }

    void ResetNPC()
    {
        _highlightedNPC.GetComponent<Renderer>().material = _originalMaterial;
        _highlightedNPC = null;
        _originalMaterial = null;
    }
}
