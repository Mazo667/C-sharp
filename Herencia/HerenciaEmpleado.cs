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
//Heredo de la clase Empleado
class EmpleadoContrato : Empleado {
	public string IDimpuestoFederal;
    public EmpleadoContrato(String nombre, Sting apellido, int edad, double tarifa){
        //Calcular Paga
    }
}
