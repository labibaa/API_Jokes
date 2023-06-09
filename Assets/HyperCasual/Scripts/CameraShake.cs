using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{

    private void OnEnable()
    {
        DetectCollision.OnCollideHex += ShakeCamera;
    }
    private void OnDisable()
    {
        DetectCollision.OnCollideHex -= ShakeCamera;
    }

    public float shakeDuration = 0.5f;
    public float shakeIntensity = 0.1f;

    private Vector3 originalPosition;
    private float currentShakeDuration = 0f;

    private void Start()
    {
        originalPosition = transform.localPosition;
    }

    private void Update()
    {
        if (currentShakeDuration > 0)
        {
            // Generate a random offset within a unit sphere
            Vector3 randomOffset = Random.insideUnitSphere * shakeIntensity;

            // Apply the offset to the camera's position
            transform.localPosition = originalPosition + randomOffset;

            // Decrease the shake duration over time
            currentShakeDuration -= Time.deltaTime;
        }
        else
        {
            // Reset the camera's position
            transform.localPosition = originalPosition;
        }
    }

    public void ShakeCamera()
    {
        currentShakeDuration = shakeDuration;
    }
}
