using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountObjects : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("1111");
        if (collision.gameObject.name == "Bascet")
        {
            Debug.Log("333");
            if (gameObject.tag == "Apple")
            {
                Destroy(gameObject);
                if (GameController.checkLevelOne == true)
                {
                    ScoreText.scoreValue++;
                }
            }
            if (gameObject.tag == "Carrot")
            {
                Destroy(gameObject);
                if (GameController.checkLevelTwo == true)
                {
                    ScoreText.scoreValue++;
                }
            }

            if (gameObject.tag == "Salmon")
            {
                Destroy(gameObject);
                if (GameController.checkLevelThree == true)
                {
                    ScoreText.scoreValue++;
                }
            }
            if (gameObject.tag == "MushEat")
            {
                Debug.Log("222");
                Destroy (this.gameObject);
                ScoreText.scoreValue++;
              
            }
        }

        /* IEnumerator BlinkBasket()
         {
             _blinkBasket.spriteRend.material = _blinkBasket.matBlink;


             while (true)
             {
                 yield return new WaitForSeconds(0.05f);
                 Debug.Log("!!!!!!!");
                 _blinkBasket.spriteRend.material = _blinkBasket.matDefault;
                 yield break;
             }

         }*/
    }
}

        