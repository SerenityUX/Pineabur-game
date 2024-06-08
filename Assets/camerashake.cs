using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public float amplitude = 0.1f; // Amplitude of the shake
    public float frequency = 1.0f; // Frequency of the shake

    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.localPosition;
    }

    void Update()
    {
        float shakeX = amplitude * Mathf.Sin(Time.time * frequency);
        float shakeY = amplitude * Mathf.Cos(Time.time * frequency);
        transform.localPosition = initialPosition + new Vector3(shakeX, shakeY, 0);
    }
}
