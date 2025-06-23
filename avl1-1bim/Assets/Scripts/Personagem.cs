using UnityEngine;

public class Personagem : MonoBehaviour
{
    
    
    [SerializeField] private string nome;
    
    [SerializeField] private int vida;
    
    [SerializeField] private int forca;
    
    [SerializeField] private float velocidade;

    
    
    public string GetNome() { return nome; }
    public void SetNome(string value) { nome = value; }

    public int GetVida() { return vida; }
    public void SetVida(int value) { vida = value; }

    public int GetForca() { return forca; }
    public void SetForca(int value) { forca = value; }

    public float GetVelocidade() { return velocidade; }
    public void SetVelocidade(float value) { velocidade = value; }
    
    
    
    public bool TemMaisForcaQue(Personagem outro)
    {
        
        return this.forca > outro.forca;
        
    }
}