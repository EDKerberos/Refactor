using UnityEngine;

public class VfxScript : MonoBehaviour
{
    [Header("Effects")]
    [SerializeField] private ParticleSystem partSys;
    public void ParticleEffect()
    {
        partSys.Play();
    }
}
