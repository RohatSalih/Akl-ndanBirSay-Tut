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
        print("Benimle Oyun Oynamak �ster misin? (E/H)");

    }

    // Update is called once per frame
    void Update()
    {
        if (!oyunBasladi)
        {
            //--------ba�lang��--------
            if (Input.GetKeyDown(KeyCode.E))
            {
                print("Harika! Akl�ndan 1-100 aras�nda bir say� tut ve Enter tu�una bas!");
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
            //--------ba�lang��----------------------
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
                print("Ya�as�n! Akl�ndaki Say�y� Buldum.");
                oyunBitti = true;
            }
            //---------oyun---------------------

        }

    }
    void kontrol()
    {
        tahmin = (minSayi + maxSayi) / 2;
        print("Akl�ndan Tuttu�un Say� " + tahmin + " mi? Daha b�y�k ise yukar�, daha k���k ise a�a�� y�n tu�una bas! Do�ruysa Space bas!");

    }
}
