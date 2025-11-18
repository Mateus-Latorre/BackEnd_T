namespace Exemplos
{
    public class ControleRemoto : IControle
    {
        public int NivelVolume = 99;
        public int VolumeMaximo = 100;
        public void Ligar()
        {
            Console.WriteLine($"Tv ligando ...");

        }

        public void AumentarVolume()
        {
            if (NivelVolume < VolumeMaximo)
            {
                NivelVolume++;
                Console.WriteLine($"Volume Atual: {NivelVolume}");
            }
            else
            {
                Console.WriteLine($"A TV atingiu o nível máximo {NivelVolume}");
            }
        }
        public void DiminuirVolume()
        {
            if (NivelVolume == 0)
            {
                Console.WriteLine($"O volumo já está no mínimo {NivelVolume}");
            }
            else
            {
                NivelVolume--;
                Console.WriteLine($"Volume atual: {NivelVolume}");
            }
        }

        public void Desligar()
        {
            Console.WriteLine($"Desligando a tv ...");
        }
    }
}