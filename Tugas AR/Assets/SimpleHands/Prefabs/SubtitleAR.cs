using UnityEngine;
using TMPro; // Wajib ditambahkan untuk memanggil teks modern Unity

public class SubtitleAR : MonoBehaviour
{
    [Header("Masukkan Teks Kuning Ke Sini:")]
    public TMP_Text teksSubtitle;

    // Fungsi ini akan dipanggil oleh Vuforia saat kartu terlihat
    public void MunculkanTeks(string huruf)
    {
        teksSubtitle.text = "Huruf " + huruf + " - Isyarat Dasar";
    }

    // Fungsi ini dipanggil saat kartu dijauhkan dari kamera
    public void HilangkanTeks()
    {
        teksSubtitle.text = "----------------";
    }
}