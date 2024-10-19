

namespace Tarea_Programacion
{
    public class SuperHeroe
    {
        public string Nombre { get; set; }

        public string IdentidadSecreta { get; set; }

        public string Ciudad { get; set; }

        public bool PuedeVolar { get; set; }

        public SuperPoder Poder;

        public SuperHeroe()
        {
            Poder = new SuperPoder();
        }

        public void Imprimir()
        {
            Console.WriteLine($"Nombre:   {Nombre}");
            Console.WriteLine($"IdentidadSecreta:    {IdentidadSecreta}");
            Console.WriteLine($"Ciudad:    {Ciudad}");
            Console.WriteLine($"PuedeVolar:     {PuedeVolar}");
            Console.WriteLine($"SuperPoder:    {Poder.Nombre}");
            Console.WriteLine($"Descripcion:     {Poder.Descripcion}");
            Console.WriteLine($"Nivel:      {Poder.Nivel}");
            Console.WriteLine();


        }
    }
}
