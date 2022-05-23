using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunControl : MonoBehaviour
{
    int minSayi = 1;
    int maxSayi = 100;
    int tahmin;
    bool oyunBasladi = false;
    bool oyunBitti = false;
    // Start is called before the first frame update
    void Start()
    {
        print("Benimle Oyun Oynamak Ýster misin? (E/H)");

    }

    // Update is called once per frame
    void Update()
    {
        if (!oyunBasladi)
        {
            //--------baþlangýç--------
            if (Input.GetKeyDown(KeyCode.E))
            {
                print("Harika! Aklýndan 1-100 arasýnda bir sayý tut ve Enter tuþuna bas!");
            }
            else if (Input.GetKeyDown(KeyCode.H))
            {
                print("Sen Bilirsin..");
            }
            if (Input.GetKeyDown(KeyCode.Return))
            {
                kontrol();
                oyunBasladi = true;
            }
            //--------baþlangýç----------------------
        }
        else if(!oyunBitti)
        {
            //---------oyun---------
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                minSayi = tahmin;
                kontrol();
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                maxSayi = tahmin;
                kontrol();
            }
            else if (Input.GetKeyDown(KeyCode.Space))
            {
                print("Yaþasýn! Aklýndaki Sayýyý Buldum.");
                oyunBitti = true;
            }
            //---------oyun---------------------

        }

    }
    void kontrol()
    {
        tahmin = (minSayi + maxSayi) / 2;
        print("Aklýndan Tuttuðun Sayý " + tahmin + " mi? Daha büyük ise yukarý, daha küçük ise aþaðý yön tuþuna bas! Doðruysa Space bas!");

    }
}
