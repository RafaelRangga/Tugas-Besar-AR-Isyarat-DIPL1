using UnityEngine;

[RequireComponent(typeof(CanvasGroup))]
public class EfekMuncul : MonoBehaviour
{
    [Header("Pengaturan Animasi")]
    [Tooltip("Semakin besar angkanya, semakin cepat layar muncul")]
    public float kecepatanMuncul = 3f;

    private CanvasGroup grupTransparansi;

    void Awake()
    {
        // Mengambil komponen pengatur transparansi layar
        grupTransparansi = GetComponent<CanvasGroup>();
    }

    void OnEnable()
    {
        // Setiap kali layar ini dipanggil (SetActive true), mulai dari tembus pandang (0)
        if (grupTransparansi != null)
        {
            grupTransparansi.alpha = 0f;
        }
    }

    void Update()
    {
        // Secara perlahan naikkan ketebalannya sampai menjadi solid (1)
        if (grupTransparansi != null && grupTransparansi.alpha < 1f)
        {
            grupTransparansi.alpha += Time.deltaTime * kecepatanMuncul;
        }
    }
}