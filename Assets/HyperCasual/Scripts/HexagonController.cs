using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexagonController : MonoBehaviour
{
    private bool isRotating = false;

    void Update()
    {
        // Check if left mouse button is down
        if (Input.GetMouseButtonDown(0))
        {
            isRotating = true;
        }

        // Check if left mouse button is released
        if (Input.GetMouseButtonUp(0))
        {
            isRotating = false;
        }

        // Rotate the GameObject if left mouse button is held down
        if (isRotating)
        {
            // Get the mouse position
            Vector3 mousePosition = Input.mousePosition;

            // Convert mouse position to world space
            Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(mousePosition);

            // Calculate the direction from the GameObject to the mouse position
            Vector3 direction = mouseWorldPosition - transform.position;

            // Calculate the angle in degrees
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

            // Rotate the GameObject around the Z-axis
            transform.rotation = Quaternion.Euler(0f, 0f, angle);
        }
    }
}
