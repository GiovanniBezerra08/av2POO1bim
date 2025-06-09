using UnityEngine;

public class Personagem : MonoBehaviour
{
    public string nome;
    public int energia;
    public float agilidade;
    public float forcaAtaque;
    public string movimento;

    public void setNome(string nome)
    {
        this.nome = nome;
    }

    public string Nome()
    {
       return nome;
    }

    public void setEnergia(int energia)
    {
        this.energia = energia;
    }
    
    public void setAgilidade(float agilidade)
    {
        this.agilidade = agilidade;
    }
    
    public void setForcaAtaque(float forcaAtaque)
    {
        this.forcaAtaque = forcaAtaque;
    }
    
    
    public void setMovimento(string movimento)
    {
        this.movimento = movimento;
    }
    
    
    
    
    
    
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
