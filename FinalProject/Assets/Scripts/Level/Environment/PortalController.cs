using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            StartCoroutine(CombatTransition());
        }
    }

    IEnumerator CombatTransition()
    {
        SceneManager.LoadScene(2);
        yield return new WaitForSeconds(5f);
    }
}
