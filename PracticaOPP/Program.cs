using PracticaOPP;

//Persona y Estudiante
Estudiante estudiante = new Estudiante();
estudiante.Registrar();
estudiante.MostrarDatos();

// Figuras
Rectangulo rectangulo = new Rectangulo();
rectangulo.RegistrarFigura();
rectangulo.calcularArea();
rectangulo.MostrarResultado();

Circulo circulo = new Circulo();
circulo.RegistrarFigura();
circulo.calcularArea();
circulo.MostrarResultado();

Triangulo triangulo = new Triangulo();
triangulo.RegistrarFigura();
triangulo.calcularArea();
triangulo.MostrarResultado();