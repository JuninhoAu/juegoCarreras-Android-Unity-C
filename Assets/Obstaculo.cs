using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstaculo : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision other) {
        
        if (other.transform.CompareTag("Player"))
        {
            Debug.Log("acabas de choca");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
