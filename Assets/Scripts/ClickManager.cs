using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ClickManager : MonoBehaviour
{
    bool pickUpCoin = false;
    bool pickupChest = false;
    public Text coinsText;
    public AudioClip coinPickUp;
    public int coins;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null)
            {
                Debug.Log(hit.collider.gameObject.tag);
                hit.collider.attachedRigidbody.AddForce(Vector2.up);

                if(hit.collider.gameObject.tag == "Coin")
                {
                    Destroy(GetComponent<Collider>().gameObject);
                    PickUpCoin();
                }
            }
        }

        void PickUpCoin()
        {
            //Debug.Log("Collided");
            pickUpCoin = true;
            coins += 1;
            AudioSource.PlayClipAtPoint(coinPickUp, transform.position);
        }
    }

}