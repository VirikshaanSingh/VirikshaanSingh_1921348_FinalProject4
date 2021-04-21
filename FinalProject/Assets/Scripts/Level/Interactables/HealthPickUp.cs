using UnityEngine;

public class DamagePickUp : MonoBehaviour
{
    public bool interactable;
    public StatScript stat;

    void Start()
    {
        interactable = false;
    }

    private void Update()
    {
        if (interactable && Input.GetKeyDown(KeyCode.Mouse0))
        {
            PickUpObject();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            interactable = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            interactable = false;
        }
    }

    public void PickUpObject()
    {
        stat.hpCurrent -= 10;
        Destroy(gameObject);
    }
}
