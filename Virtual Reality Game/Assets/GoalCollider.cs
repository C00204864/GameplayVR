using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoalCollider : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        int levelNo = 0;
        if (collision.gameObject.name == "Sphere")
        {
            string sceneName = SceneManager.GetActiveScene().name;
            char last = sceneName[sceneName.Length - 1];
            levelNo = last - 48;
            levelNo++;
            if (4 == levelNo)
            {
                Application.Quit();
            }
            else
            {
                SceneManager.LoadScene("level" + levelNo);
            }
        }
    }
}