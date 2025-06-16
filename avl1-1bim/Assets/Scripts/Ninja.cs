using UnityEngine;

public class Ninja : Personagem
    
{
    public enum ArmaDoNinja
    {
        SHURINKEN, CLONE
    }

    private ArmaDoNinja poderes;

    public void setAmaDoNinja(ArmaDoNinja poderes);
    {
        this.poderes = poderes;
    }

    public ArmaDoNinja getArmaDoNinja()
    {
        return poderes;
    }

    public int DanoDoPersonagem()
    {
        int buff = 0;

        switch (poderes)
        {
            case ArmaDoNinja.SHURINKEN:
                buff = getForcaAtaque() + 40;
        }
    }
}
