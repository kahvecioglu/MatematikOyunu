using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DortIslem : MonoBehaviour
{
    public Text ilksayi, ikincisayi, islem, sonuc,cevap;
    public InputField sonucInput;

    int sayi1, sayi2, islemIsareti,islemsonucu;
    // Start is called before the first frame update
    void Start()
    {
        YeniSoru();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CevapKontrol()
    {
        if (int.Parse(cevap.text) == islemsonucu)
        {
            sonuc.text = "Doðru";
        }
        else
        {
            sonuc.text = "Yanlýþ ";
        }

    }

    public void YeniSoru()
    {
        sonuc.text = " ";
        sonucInput.text = " ";

        sayi1 = Random.Range(1, 10);
        sayi2 = Random.Range(1, 10);
        islemIsareti = Random.Range(1, 5);

        switch (islemIsareti)
        {
            case 1:
                islem.text = "+";
                islemsonucu = sayi1 + sayi2;
                break;

            case 2:
                islem.text = "-";
                islemsonucu = sayi1 - sayi2;
                break;
            case 3:
                islem.text = "*";
                islemsonucu = sayi1 * sayi2;
                break;
            case 4:
                islem.text = "/";
                if(sayi2 > sayi1)
                {
                    sayi1 = sayi2;
                    sayi2 = sayi1;
                    islemsonucu = sayi1 / sayi2;
                }else
                {
                    islemsonucu = sayi1 / sayi2;
                }
                
                break;

        }
        ilksayi.text = sayi1 + "";
        ikincisayi.text = sayi2 + "";


    }
}
