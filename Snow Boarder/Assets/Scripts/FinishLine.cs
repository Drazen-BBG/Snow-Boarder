using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float loadDelay = 1.0f;
    [SerializeField] ParticleSystem finishEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Invoke("ReloadSceneMethod", loadDelay);
        }
    }

    void ReloadSceneMethod()
    {
        Debug.Log("Win");
        SceneManager.LoadScene(0);
    }
}
