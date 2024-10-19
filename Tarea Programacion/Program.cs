
using Tarea_Programacion;

SuperHeroe superHeroe = new SuperHeroe();

superHeroe.Nombre = "Aquaman";
superHeroe.IdentidadSecreta = "Arthur Curry";
superHeroe.Ciudad = "Atlantis";
superHeroe.PuedeVolar = false;
superHeroe.Poder.Nombre = "Ecolocalizacion";
superHeroe.Poder.Descripcion = "Capacidad para comunicarse con seres marinos";
superHeroe.Poder.Nivel = 5;
superHeroe.Imprimir();

SuperHeroe superHeroe1 = new SuperHeroe();

superHeroe1.Nombre = "Deadpool";
superHeroe1.IdentidadSecreta = "Wade Wilson";
superHeroe1.Ciudad = "New York";
superHeroe1.PuedeVolar = false;
superHeroe1.Poder.Nombre = "Inmortalidad, dominio de armas, autoregeneracion, resistencia";
superHeroe1.Poder.Descripcion = "No puede morir";
superHeroe1.Poder.Nivel = 8;
superHeroe1.Imprimir();

SuperHeroe superHeroe2 = new SuperHeroe();

superHeroe2.Nombre = "La Bruja Escarlata";
superHeroe2.IdentidadSecreta = "Wanda Maximoff";
superHeroe2.Ciudad = "Sokovia";
superHeroe2.PuedeVolar = true;
superHeroe2.Poder.Nombre = "Manipulación mental, Energía psiónica,Telequinesis, Generación de campos de fuerza ";
superHeroe2.Poder.Descripcion = "Sus poderes se manifiestan en cualquier forma como corrientes de energía de color roja que sale de sus manos";
superHeroe2.Poder.Nivel = 10;
superHeroe2.Imprimir();