using UnityEngine;
using System.Collections;

public class FadeToNewMaterial : MonoBehaviour
{
    public Material newMaterial; // Assign the new material in the Inspector
    public float fadeDuration = 20f; // Duration for the fade effect

    private Renderer _renderer;
    private Material _originalMaterial;
    private bool _isFading = false;

    void Start()
    {
        _renderer = GetComponent<Renderer>();
        _originalMaterial = _renderer.material;
    }

    void Update()
    {
        if (!_isFading && Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(FadeToMaterial(newMaterial));
        }
    }

    private IEnumerator FadeToMaterial(Material targetMaterial)
    {
        _isFading = true;
        Material initialMaterial = _renderer.material;
        float elapsedTime = 0f;

        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            float blend = Mathf.Clamp01(elapsedTime / fadeDuration);
            _renderer.material.Lerp(initialMaterial, targetMaterial, blend);
            yield return null;
        }

        _renderer.material = targetMaterial;
        _isFading = false;
    }
}
