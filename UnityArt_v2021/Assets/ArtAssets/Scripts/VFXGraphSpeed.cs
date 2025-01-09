using UnityEngine;
using UnityEngine.VFX;

public class VFXGraphSpeed : MonoBehaviour
{
    [SerializeField] float timeScale = 1.0f;
    private VisualEffect VFX;

    void Start()
    {
        VFX = GetComponent<VisualEffect>();
    }

    void Update()
    {
        VFX.playRate = timeScale;
    }
}