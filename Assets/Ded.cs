using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class Ded : MonoBehaviour {
    public float shrivelUpTime = 5;

    private bool isDed = false;

	public void ZeroHealth() {
        isDed = true;
    }

    private void Update() {
        if (isDed) {
            transform.localScale -= Vector3.one * Time.deltaTime / shrivelUpTime;

            if (transform.localScale.x <= 0) {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
