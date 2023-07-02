using System;
class Empleado{
	public Empleado(string nombre, string apellido, int edad, double tarifa){
		this.nombre = nombre;
		this.apellido = apellido;
 		this.edad = edad;
		this.tarifa = tarifa;
	}
	protected string nombre;
	protected string apellido;
	protected int edad;
	protected double tarifa;
	public double CalcularPaga(int horasTrabajadas){
		return(tarifa*(double)horasTrabajadas);
	}
}
public class app{
    public static void Main(){
	Empleado emp = new Empleado("Amy","Anderson",28,100);
	Empleado emp2 = new Empleado("Amy","Anderson",28,100);
			Console.WriteLine(emp.CalcularPaga(20));
			Console.WriteLine(emp.CalcularPaga(50));
    }
}