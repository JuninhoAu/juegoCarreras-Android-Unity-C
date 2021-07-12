using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Victoria : MonoBehaviour
{
     private void OnCollisionEnter(Collision other) {
        
        if (other.transform.CompareTag("Player"))
        {
            Debug.Log("acabas de choca");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
    }
}
