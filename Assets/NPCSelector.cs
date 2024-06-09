using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NPCSelector : MonoBehaviour
{
    private Camera _mainCamera;
    private GameObject _highlightedNPC;
    private Material _originalMaterial;
    public Material glowMaterial; // Assign a material with glow and stroke effects
    public Texture2D defaultCursor;
    public Texture2D pointerCursor;

    void Start()
    {
        _mainCamera = Camera.main;
        Cursor.SetCursor(defaultCursor, Vector2.zero, CursorMode.Auto);
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
                    Cursor.SetCursor(pointerCursor, Vector2.zero, CursorMode.Auto); // Change cursor to pointer cursor
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
        if (_highlightedNPC != null && (Input.GetKeyDown(KeyCode.E) || Input.GetMouseButtonDown(0)))
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
        Cursor.SetCursor(defaultCursor, Vector2.zero, CursorMode.Auto); // Reset cursor to default
    }
}
